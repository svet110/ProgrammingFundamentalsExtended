using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterBase
{
    class FilterBase
    {
        static void Main()
        {
            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "filter base")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[0];
                var secElement = tokens[1];

                int age = 0;
                double salary = 0.0;
                string position = string.Empty;

                if (int.TryParse(secElement, out age))
                {
                    age = int.Parse(secElement);
                    nameAge[firstElement] = age;
                }
                else if (double.TryParse(secElement, out salary))
                {
                    salary = double.Parse(secElement);
                    nameSalary[firstElement] = salary;
                }
                else
                {
                    position = secElement;
                    namePosition[firstElement] = position;
                }

                input = Console.ReadLine();
            }

            string secInput = Console.ReadLine();

            if (secInput == "Age")
            {
                foreach (var name in nameAge)
                {
                    Console.WriteLine("Name: {0}", name.Key);
                    Console.WriteLine("Age: {0}", name.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (secInput == "Salary")
            {
                foreach (var name in nameSalary)
                {
                    Console.WriteLine("Name: {0}", name.Key);
                    Console.WriteLine("Salary: {0:f2}", name.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var name in namePosition)
                {
                    Console.WriteLine("Name: {0}", name.Key);
                    Console.WriteLine("Position: {0}", name.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
