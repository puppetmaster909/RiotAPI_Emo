using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Riot_API_Demo
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        override public string ToString()
        {
            return "";
        }
    }
}
