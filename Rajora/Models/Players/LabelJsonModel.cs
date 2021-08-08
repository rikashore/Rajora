﻿using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LabelJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iconUrls")]
        public LabelIconJsonModel IconUrls { get; set; }
    }
}