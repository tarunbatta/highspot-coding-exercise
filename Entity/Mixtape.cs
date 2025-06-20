using System.Collections.Generic;

namespace highspot.Entity
{
    public class Mixtape
    {
        public List<User> users { get; set; } = new List<User>();
        public List<Playlist> playlists { get; set; } = new List<Playlist>();
        public List<Song> songs { get; set; } = new List<Song>();

        public Mixtape()
        {

        }
    }
}