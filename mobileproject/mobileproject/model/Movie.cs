using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mobileproject
{
    class Movie
    {
        [JsonProperty(PropertyName = "Title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "Year")]
        public string year { get; set; }

        [JsonProperty(PropertyName = "Rated")]
        public string age { get; set; }

        [JsonProperty(PropertyName = "Released")]
        public string date { get; set; }

        [JsonProperty(PropertyName = "Runtime")]
        public string runtime { get; set; }

        [JsonProperty(PropertyName = "Genre")]
        public string genre { get; set; }

        [JsonProperty(PropertyName = "Director")]
        public string director { get; set; }

        [JsonProperty(PropertyName = "Writer")]
        public string writer { get; set; }

        [JsonProperty(PropertyName = "Actors")]
        public string actor { get; set; }

        [JsonProperty(PropertyName = "Plot")]
        public string plot { get; set; }

        [JsonProperty(PropertyName = "Language")]
        public string language { get; set; }

        [JsonProperty(PropertyName = "Country")]
        public string country { get; set; }

        [JsonProperty(PropertyName = "Awards")]
        public string awards { get; set; }

        [JsonProperty(PropertyName = "Poster")]
        public string poster { get; set; }

        [JsonProperty(PropertyName = "Metascore")]
        public string metascore { get; set; }

        [JsonProperty(PropertyName = "imdbRating")]
        public string imdbrating { get; set; }

        [JsonProperty(PropertyName = "imfbVotes")]
        public string imdbvotes { get; set; }

        [JsonProperty(PropertyName = "imdbID")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "Type")]
        public string type { get; set; }

        [JsonProperty(PropertyName = "Response")]
        public string response { get; set; }
    }
}
