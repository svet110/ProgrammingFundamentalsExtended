using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    public class SplinterTrip
    {
        public static void Main()
        {
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal tankCapacity = decimal.Parse(Console.ReadLine());
            decimal additionalMilesInHeavyWinds = decimal.Parse(Console.ReadLine());
            int consumptionPerMile = 25;
            decimal additionalFuelNeeded = 1.5m;
            decimal tolerance = 0.05m;

            decimal nonAditionalDistance = distance - additionalMilesInHeavyWinds;
            decimal nonAdditionalConsumtion = nonAditionalDistance * consumptionPerMile;
            decimal additionalConsumption = additionalMilesInHeavyWinds * (consumptionPerMile * additionalFuelNeeded);
            decimal totalConsumption = nonAdditionalConsumtion + additionalConsumption;
            decimal fuelTolerance = totalConsumption * tolerance;
            decimal final = totalConsumption + fuelTolerance;

            Console.WriteLine("Fuel needed: {0:f2}L", final);

            if (tankCapacity - final >= 0)
            {
                Console.WriteLine("Enough with {0:f2}L to spare!", (tankCapacity - final));
            }
            else
            {
                Console.WriteLine("We need {0:f2}L more fuel.", (final - tankCapacity));
            }
        }
    }
}
