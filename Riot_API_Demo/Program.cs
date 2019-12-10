using System;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace Riot_API_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-a78d4827-293f-4f46-971b-6e62fd4446b6");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA1, "Puppetmaster909");

            Console.WriteLine($"Name: {summoner.Name} Level: {summoner.SummonerLevel}");

            //SummonerV4 summonerApi = new SummonerV4();
            //var summoner = summonerApi.GetSummonerByName("Puppetmaster909");
            //Console.WriteLine($"Name: {summoner.Name} Level: {summoner.SummonerLevel}");
        }
    }
}
