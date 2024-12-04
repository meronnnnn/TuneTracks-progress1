namespace TuneTracks.Models
{
    public class Album
    {
        public int AlbumID {  get; set; }
        public string Title {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ArtistID {  get; set; }
        public Artist Artist { get; set; }
        public ICollection<Song>Songs { get; set; }
    }
}
