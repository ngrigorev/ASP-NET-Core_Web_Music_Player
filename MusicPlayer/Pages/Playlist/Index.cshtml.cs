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
    public class IndexPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public IndexPlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Playlist> Playlist { get;set; }

        public async Task OnGetAsync()
        {
            Playlist = await _context.Playlists.ToListAsync();
        }
    }
}
