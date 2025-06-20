using System.Collections.Generic;

namespace highspot.Entity
{
    public class AddPlaylist : IChange
    {
        public string id { get; set; } = string.Empty;
        public string user_id { get; set; } = string.Empty;
        public List<string> song_ids { get; set; } = new List<string>();

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