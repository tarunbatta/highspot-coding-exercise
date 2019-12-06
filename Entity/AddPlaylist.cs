using System.Collections.Generic;

namespace highspot.Entity
{
    public class AddPlaylist : IChange
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public List<string> song_ids { get; set; }

        public AddPlaylist()
        {

        }

        public AddPlaylist(string _id, string userId, List<string> songIds)
        {
            this.id = _id;
            this.user_id = userId;
            this.song_ids = songIds;
        }
    }
}