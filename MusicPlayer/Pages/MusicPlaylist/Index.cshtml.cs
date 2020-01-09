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
    public class IndexMusicPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public IndexMusicPlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MusicPlaylist> MusicPlaylist { get;set; }

        public async Task OnGetAsync()
        {
            MusicPlaylist = await _context.MusicPlaylist
                .Include(m => m.Music)
                .Include(m => m.Playlist).ToListAsync();
        }
    }
}
