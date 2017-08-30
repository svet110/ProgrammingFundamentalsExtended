using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                AddGrade(grades, name, grade);
            }

            foreach (var grade in grades)
            {
                Console.WriteLine("{0} -> {1:f2} (avg: {2:f2})", 
                    grade.Key, 
                    string.Join(" ", grade.Value.Select(p => string.Format("0:f2", p))), 
                    grade.Value.Average());
            }
        }

        public static void AddGrade(Dictionary<string, List<double>> grades, string name, double grade)
        {
            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<double>();
            }
            grades[name].Add(grade);
        }
    }
}
