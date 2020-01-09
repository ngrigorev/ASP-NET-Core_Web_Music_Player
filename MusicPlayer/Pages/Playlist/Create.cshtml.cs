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
    public class CreatePlaylist : PageModel
    {
        private readonly MusicPlayer.Data.ApplicationDbContext _context;

        public CreatePlaylist(MusicPlayer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Playlist Playlist { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Playlists.Add(Playlist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
