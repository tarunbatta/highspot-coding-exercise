namespace highspot.Entity
{
    public class AddSong : IChange
    {
        public string id { get; set; }
        public string playlist_id { get; set; }

        public AddSong()
        {

        }
    }
}