using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main()
        {
            var users = new Dictionary<string, DateTime>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputLine = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string user = inputLine[0];
                DateTime date = DateTime.ParseExact(inputLine[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                users[user] = date;

                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> sorted = users
                .Reverse()
                .OrderBy(u => u.Value)
                .Take(5)
                .OrderByDescending(u => u.Value)
                .ToDictionary(u => u.Key, u => u.Value);

            foreach (var sortedName in sorted)
            {
                Console.WriteLine("{0}", sortedName.Key);
            }
        }
    }
}
