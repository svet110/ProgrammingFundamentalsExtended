using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var soldierActivity = new Dictionary<string, int>();
            var legionSoldiers = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }
                    ,StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(line[0]);
                string legionName = line[1];
                string soldierType = line[2];
                int soldierCount = int.Parse(line[3]);

                if (!soldierActivity.ContainsKey(legionName))
                {
                    legionSoldiers.Add(legionName, new Dictionary<string, long>());
                    soldierActivity.Add(legionName, lastActivity);
                }

                if (soldierActivity[legionName] < lastActivity)
                {
                    soldierActivity[legionName] = lastActivity;
                }

                if (!legionSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionSoldiers[legionName][soldierType] = 0;
                }

                legionSoldiers[legionName][soldierType] += soldierCount;
            }

            string[] secondLine = Console.ReadLine().Split('\\');

            if (secondLine.Length == 2)
            {
                int activity = int.Parse(secondLine[0]);
                string type = secondLine[1];

                foreach (var soldier in legionSoldiers
                    .Where(l => l.Value.ContainsKey(type))
                    .OrderByDescending(l => l.Value[type]))
                {
                    if (soldierActivity[soldier.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", soldier.Key, soldier.Value[type]);
                    }
                }
            }
            else
            { 
                foreach (var legion in soldierActivity.OrderByDescending(a => a.Value))
                {
                    if (legionSoldiers[legion.Key].ContainsKey(secondLine[0]))
                    {
                        Console.WriteLine("{0} : {1}", legion.Value, legion.Key);
                    }
                }
            }
        }
    }
}
