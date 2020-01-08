using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data
{
    public class Music
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Author { get; set; }
        public int Playlist_Id { get; set; }
    }
}
