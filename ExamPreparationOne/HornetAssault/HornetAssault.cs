using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beesAmount = Console.ReadLine()
            .Split(' ').Select(long.Parse).ToList();

            var hornetsPower = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beesAmount.Count; i++)
            {
                if (hornetsPower.Count == 0)
                {
                    break;
                }

                if (beesAmount[i] < hornetsPower.Sum())
                {
                    beesAmount.RemoveAt(i);
                    i--;
                }
                else
                {
                    beesAmount[i] -= hornetsPower.Sum();
                    hornetsPower.RemoveAt(0);
                }
            }

            if (beesAmount.Any(b => b > 0))
            {
                Console.WriteLine(
                    string.Join(" ", beesAmount.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsPower));
            }	
        }
    }
}
