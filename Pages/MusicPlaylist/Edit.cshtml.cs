using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data;

namespace MusicPlayer
{
    public class EditMusicPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public EditMusicPlaylist(MusicPlayer.Data.ApplicationDbContext context)
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
           ViewData["MusicId"] = new SelectList(_context.Musics, "Id", "Id");
           ViewData["PlaylistId"] = new SelectList(_context.Playlists, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MusicPlaylist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicPlaylistExists(MusicPlaylist.MusicId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MusicPlaylistExists(int id)
        {
            return _context.MusicPlaylist.Any(e => e.MusicId == id);
        }
    }
}
