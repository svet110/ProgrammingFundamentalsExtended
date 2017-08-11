using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceThousandFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            
            double distanceMoved = (wingFlaps / 1000) * distanceThousandFlaps;
            int seconds = wingFlaps / 100;
            int secondsRest = (wingFlaps / endurance) * 5;
            int totalSeconds = seconds + secondsRest;

            Console.WriteLine("{0:f2} m.", distanceMoved);
            Console.WriteLine("{0} s.", totalSeconds);	
        }
    }
}
