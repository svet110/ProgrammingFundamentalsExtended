using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();
            int age = 0;
            double salary = 0.0; 

            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                if (int.TryParse(tokens[1], out age))
                {
                    int personAge = age;
                    nameAge[name] = personAge;
                }
                else if (double.TryParse(tokens[1], out salary))
                {
                    double personSalary = salary;
                    nameSalary[name] = personSalary;
                }
                else
                {
                    string position = tokens[1];
                    namePosition[name] = position;
                }

                input = Console.ReadLine();
            }

            string filter = Console.ReadLine();
            
            switch (filter)
            {
                case "Age":
                    foreach (var name in nameAge)
                    {
                        Console.WriteLine("Name: {0}", name.Key);
                        Console.WriteLine("Age: {0}", name.Value);
                        Console.WriteLine(new string('=', 20));
                    }
                    break;

                case "Salary":
                    foreach (var name in nameSalary)
                    {
                        Console.WriteLine("Name: {0}", name.Key);
                        Console.WriteLine("Salary: {0:f2}", name.Value);
                        Console.WriteLine(new string('=', 20));
                    }
                    break;

                case "Position":
                    foreach (var name in namePosition)
                    {
                        Console.WriteLine("Name: {0}", name.Key);
                        Console.WriteLine("Position: {0}", name.Value);
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
