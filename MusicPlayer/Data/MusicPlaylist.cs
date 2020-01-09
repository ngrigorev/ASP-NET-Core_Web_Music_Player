namespace MusicPlayer.Data
{
    public class MusicPlaylist
    {
        public int MusicId { get; set; }
        public Music Music { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
    }
}
