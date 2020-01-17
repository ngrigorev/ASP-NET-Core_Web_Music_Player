using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MusicPlayer.Data
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // To link the playlist to the user
        public IdentityUser User { get; set; }

        public IList<MusicPlaylist> MusicPlaylist { get; set; }
    }
}
