namespace TuneTracks.Models
{
    public class Artist
    {
        public int ArtistID {  get; set; }
        public string ArtistName { get; set; }
        public string genre {  get; set; }
        //Navigation properties
        public ICollection<Album> Albums { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
