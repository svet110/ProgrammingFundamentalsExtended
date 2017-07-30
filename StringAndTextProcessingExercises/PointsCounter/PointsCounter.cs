using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    public class PointsCounter
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var teamsInfo = new Dictionary<string, Dictionary<string, int>>();
            string team = string.Empty;
            string player = string.Empty;

            while (input != "Result")
            {
                input = input
                    .Replace("@", string.Empty)
                    .Replace("%", string.Empty)
                    .Replace("$", string.Empty)
                    .Replace("*", string.Empty);

                string[] tokens = input.Split('|');               

                if (tokens[0].Last() > 96)
                {
                    team = tokens[1];
                    player = tokens[0];
                }
                else
                {
                    team = tokens[0];
                    player = tokens[1];
                }

                int points = int.Parse(tokens[2]);

                if (!teamsInfo.ContainsKey(team))
                {
                    teamsInfo.Add(team, new Dictionary<string, int>());
                }
                teamsInfo[team][player] = points;
                
                input = Console.ReadLine();
            }

            foreach (var teamInfo in teamsInfo.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine("{0} => {1}", teamInfo.Key, teamInfo.Value.Values.Sum());
                foreach (var playerInfo in teamInfo.Value.OrderByDescending(x => x.Value).Take(1))
                {
                    Console.WriteLine("Most points scored by {0}", playerInfo.Key);
                }                
            }
        }
    }
}
