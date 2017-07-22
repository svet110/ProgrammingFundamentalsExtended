using System;
using System.Collections.Generic;
using System.Linq;

namespace BeerPongTournament
{
    class BeerPongTournament
    {
        static void Main()
        {
            var results = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
                

            while (input != "stop the game")
            {
                string[] inputLine = input.Split('|');
                string player = inputLine[0];
                string team = inputLine[1];
                int points = int.Parse(inputLine[2]);
                

                if (!results.ContainsKey(team))
                {
                    results.Add(team, new Dictionary<string, int>());
                }
                
                if (results[team].Count < 3)
                {
                    results[team].Add(player, points);
                }

                input = Console.ReadLine();                
            }

            var sortedTeams = results
                .Where(p => p.Value.Count == 3)
                .OrderByDescending(p => p.Value.Sum(playerRecord => playerRecord.Value));

            int rank = 1;

            foreach (var teamRecord in sortedTeams)
            {
                string teamName = teamRecord.Key;
                Dictionary<string, int> playersData = teamRecord.Value;
                
                var orderedPlayersData = playersData
                    .OrderByDescending(p => p.Value);

                Console.WriteLine("{0}. {1}; Players:", rank, teamName);
                foreach (var playerRecord in orderedPlayersData)
                {
                    Console.WriteLine("###{0}: {1}", playerRecord.Key, playerRecord.Value);
                }

                rank++;
            }                    
        }
    }
}
