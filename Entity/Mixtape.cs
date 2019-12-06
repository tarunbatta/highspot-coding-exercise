using System.Collections.Generic;

namespace highspot.Entity
{
    public class Mixtape
    {
        public List<User> users { get; set; }
        public List<Playlist> playlists { get; set; }
        public List<Song> songs { get; set; }

        public Mixtape()
        {

        }
    }
}