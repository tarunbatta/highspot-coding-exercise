using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace highspot.Entity
{
    public class Change
    {
        [JsonConverter(typeof(ChangeConverter))]
        public List<IChange> changes { get; set; } = new List<IChange>();

        public Change()
        {

        }
    }
}