using System.Collections.Generic;

namespace highspot.Entity
{
    public class Playlist : PlaylistRef
    {
        public Playlist(string id, string userId, List<string> songIds) : base(id, userId, songIds)
        {

        }
    }
}