using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupContinentsCountriesAndCities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main()
        {
            var geographyObjects = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                AddObject(geographyObjects, continent, country, city);
            }

            foreach (var geoObject in geographyObjects)
            {
                string continentName = geoObject.Key;
                SortedDictionary<string, SortedSet<string>> countries = geoObject.Value;

                Console.WriteLine("{0}:", continentName);

                foreach (var country in countries)
                {
                    string countryName = country.Key;
                    SortedSet<string> cities = country.Value;

                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }

        public static void AddObject(
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> geographyObjects
            , string continent, string country, string city)
        {
            if (!geographyObjects.ContainsKey(continent))
            {
                geographyObjects[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!geographyObjects[continent].ContainsKey(country))
            {
                geographyObjects[continent][country] = new SortedSet<string>();
            }

            geographyObjects[continent][country].Add(city);
        }
    }
}
