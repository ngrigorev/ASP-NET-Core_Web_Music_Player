using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data;

namespace MusicPlayer
{
    public class DeleteMusicPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public DeleteMusicPlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MusicPlaylist MusicPlaylist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicPlaylist = await _context.MusicPlaylist
                .Include(m => m.Music)
                .Include(m => m.Playlist).FirstOrDefaultAsync(m => m.MusicId == id);

            if (MusicPlaylist == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicPlaylist = await _context.MusicPlaylist.FindAsync(id);

            if (MusicPlaylist != null)
            {
                _context.MusicPlaylist.Remove(MusicPlaylist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
