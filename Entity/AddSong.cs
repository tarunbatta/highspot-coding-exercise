namespace highspot.Entity
{
    public class AddSong : IChange
    {
        public int id { get; set; }
        public int playlist_id { get; set; }

        public AddSong()
        {

        }
    }
}