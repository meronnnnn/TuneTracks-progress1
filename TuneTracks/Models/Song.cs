namespace TuneTracks.Models
{
    public class Song
    {
        public int SongID {  get; set; }
        public string SongTitle {  get; set; }
        public TimeSpan Duration { get; set; }
        public int ArtistID {  get; set; }
        public int? AlbumID { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}
