using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main()
        {
            var geographyObjects = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                AddTown(geographyObjects, continent, country, city);
            }

            foreach (var geoObject in geographyObjects)
            {
                string continent = geoObject.Key;
                Dictionary<string, List<string>> countries = geoObject.Value;
                
                Console.WriteLine("{0}:", continent);
                
                foreach (var country in countries)
	            {
		            string name = country.Key;
                    List<string> cities = country.Value;
                    Console.WriteLine("  {0} -> {1}", name, string.Join(", ", cities));
	            }     
            }
        }

        static void AddTown(Dictionary<string, Dictionary<string, List<string>>> geographyObjects, string continent, string country, string city)
        {
            if (!geographyObjects.ContainsKey(continent))
            {
                geographyObjects[continent] = new Dictionary<string, List<string>>();
            }
            if (!geographyObjects[continent].ContainsKey(country))
            {
                geographyObjects[continent][country] = new List<string>();
            }

            geographyObjects[continent][country].Add(city);
        }
    }
}
