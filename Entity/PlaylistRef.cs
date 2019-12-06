using System.Collections.Generic;

namespace highspot.Entity
{
    public class PlaylistRef
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public List<string> song_ids { get; set; }

        public PlaylistRef()
        {

        }

        public PlaylistRef(string _id, string userId, List<string> songIds)
        {
            this.id = _id;
            this.user_id = userId;
            this.song_ids = songIds;
        }
    }
}