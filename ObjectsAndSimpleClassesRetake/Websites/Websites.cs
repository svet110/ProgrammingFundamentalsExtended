using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    public class Websites
    {
        public static void Main()
        {
            var websites = new List<Website>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string host = tokens[0];
                string domain = tokens[1];
                List<string> queries = tokens.Skip(2).ToList();

                var newWebsite = new Website() 
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                websites.Add(newWebsite);

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries.Count == 0)
                {
                    Console.Write("https://www.{0}.{1}", website.Host, website.Domain);
                }
                else
                {
                    Console.Write("https://www.{0}.{1}", website.Host, website.Domain);
                    Console.Write("/query?=[{0}]", string.Join("]&[", website.Queries));
                }

                Console.WriteLine();                
            }
        }
    }
}
