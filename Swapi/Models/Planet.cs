﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Swapi
{
   public class Planet
    {
       
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("rotation_period")]
            public string rotation_period { get; set; }
            [JsonProperty("orbital_period")]
            public string orbital_period { get; set; }
            [JsonProperty("diameter")]
            public string diameter { get; set; }
            [JsonProperty("climate")]
            public string climate { get; set; }
            [JsonProperty("gravity")]
            public string gravity { get; set; }
            [JsonProperty("terrain")]
            public string terrain { get; set; }
            [JsonProperty("surface_water")]
            public string surface_water { get; set; }
            [JsonProperty("population")]
            public string population { get; set; }
            [JsonProperty("residents")]
            public List<string> residents { get; set; }
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