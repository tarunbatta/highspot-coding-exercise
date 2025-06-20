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
            object? value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object? ReadJson(JsonReader reader,
            Type objectType, object? existingValue,
            JsonSerializer serializer)
        {
            var fields = new List<IChange>();
            var jsonArray = JArray.Load(reader);


            // Deserialize each form field.
            foreach (var item in jsonArray)
            {
                // Create a form field instance by the field type ID.
                var jsonObject = item as JObject;
                if (jsonObject == null)
                {
                    continue;
                }

                string? addSongStr = jsonObject["add_song"]?.ToString();
                string? addPlaylistStr = jsonObject["add_playlist"]?.ToString();
                string? removePlaylistStr = jsonObject["rm_playlist"]?.ToString();

                var addSong = !string.IsNullOrEmpty(addSongStr) ? JsonConvert.DeserializeObject<AddSong>(addSongStr) : null;
                var addPlaylist = !string.IsNullOrEmpty(addPlaylistStr) ? JsonConvert.DeserializeObject<AddPlaylist>(addPlaylistStr) : null;
                var removePlaylist = !string.IsNullOrEmpty(removePlaylistStr) ? JsonConvert.DeserializeObject<RemovePlaylist>(removePlaylistStr) : null;

                IChange? instance = null;

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

                if (instance != null)
                {
                    fields.Add(instance);
                }
            }

            return fields;
        }
    }
}