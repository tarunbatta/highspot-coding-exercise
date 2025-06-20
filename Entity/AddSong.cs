namespace highspot.Entity
{
    public class AddSong : IChange
    {
        public string id { get; set; } = string.Empty;
        public string playlist_id { get; set; } = string.Empty;

        public AddSong()
        {

        }
    }
}