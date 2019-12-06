using System.Collections.Generic;

namespace highspot.Entity
{
    public class PlaylistRef
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public List<int> song_ids { get; set; }

        public PlaylistRef()
        {

        }
    }
}