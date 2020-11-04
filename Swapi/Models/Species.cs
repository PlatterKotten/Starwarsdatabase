using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Swapi
{
    public class Species
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("classification")]
        public string classification { get; set; }
        [JsonProperty("designation")]
        public string designation { get; set; }
        [JsonProperty("average_height")]
        public string average_height { get; set; }
        [JsonProperty("skin_colors")]
        public string skin_colors { get; set; }
        [JsonProperty("hair_colors")]
        public string hair_colors { get; set; }
        [JsonProperty("eye_colors")]
        public string eye_colors { get; set; }
        [JsonProperty("average_lifespan")]
        public string average_lifespan { get; set; }
        [JsonProperty("homeworld")]
        public string homeworld { get; set; }
        [JsonProperty("language")]
        public string language { get; set; }
        [JsonProperty("people")]
        public List<string> people { get; set; }
        [JsonProperty("films")]
        public List<string> films { get; set; }
        [JsonProperty("created")]
        public DateTime created { get; set; }
        [JsonProperty("edited")]
        public DateTime edited { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
    }
}
