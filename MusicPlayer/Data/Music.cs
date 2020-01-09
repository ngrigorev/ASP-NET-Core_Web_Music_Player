using System.Collections.Generic;

namespace MusicPlayer.Data
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string File { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }

        public IList<MusicPlaylist> MusicPlaylist { get; set; }
    }
}
