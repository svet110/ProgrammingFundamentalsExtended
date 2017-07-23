﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Websites
{
    public class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Website(string host, string domain, List<string> queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queries = queries;
        }
    }    
    class Websites
    {
        static void Main()
        {
            var websites = new List<Website>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] parts = input.Split(new string[] { " | "}, StringSplitOptions.RemoveEmptyEntries);
                string host = parts[0];
                string domain = parts[1];
                List<string> queries = parts.Skip(2).ToList();

                if (parts.Length > 2)
                {
                    queries = parts[2].Split(',').ToList();
                }
                else
                {
                    queries = new List<string>();
                }

                websites.Add(new Website(host, domain, queries));               
                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write("https://www.{0}.{1}",
                    website.Host,
                    website.Domain);

                if (website.Queries.Count > 0)
                {
                    Console.Write("/query?=[{0}]",
                        string.Join("]&[", website.Queries));
                }

                Console.WriteLine();
            }
        }
    }
}
