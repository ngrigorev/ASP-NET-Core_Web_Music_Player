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
    public class DetailsPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public DetailsPlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Playlist Playlist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Playlist = await _context.Playlists.FirstOrDefaultAsync(m => m.Id == id);

            Playlist = await _context.Playlists
                .Include(s => s.MusicPlaylist)
                    .ThenInclude(g => g.Music)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Playlist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
