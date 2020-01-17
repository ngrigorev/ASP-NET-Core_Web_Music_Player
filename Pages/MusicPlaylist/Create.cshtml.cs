using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicPlayer.Data;

namespace MusicPlayer
{
    public class CreateMusicPlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public CreateMusicPlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MusicId"] = new SelectList(_context.Musics, "Id", "Id");
        ViewData["PlaylistId"] = new SelectList(_context.Playlists, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public MusicPlaylist MusicPlaylist { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MusicPlaylist.Add(MusicPlaylist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
