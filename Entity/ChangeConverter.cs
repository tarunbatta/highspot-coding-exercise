using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace highspot.Entity
{
    public class ChangeConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IChange);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var fields = new List<IChange>();
            var jsonArray = JArray.Load(reader);


            // Deserialize each form field.
            foreach (var item in jsonArray)
            {
                // Create a form field instance by the field type ID.
                var jsonObject = item as JObject;

                var addSong = jsonObject["add_song"] == null ? null : JsonConvert.DeserializeObject<AddSong>(jsonObject["add_song"].ToString());
                var addPlaylist = jsonObject["add_playlist"] == null ? null : JsonConvert.DeserializeObject<AddPlaylist>(jsonObject["add_playlist"].ToString());
                var removePlaylist = jsonObject["rm_playlist"] == null ? null : JsonConvert.DeserializeObject<RemovePlaylist>(jsonObject["rm_playlist"].ToString());

                dynamic instance = new AddSong();

                if (addSong != null)
                {
                    instance = addSong;
                }
                else if (addPlaylist != null)
                {
                    instance = addPlaylist;
                }
                else if (removePlaylist != null)
                {
                    instance = removePlaylist;
                }

                fields.Add(instance);
            }

            return fields;
        }
    }
}