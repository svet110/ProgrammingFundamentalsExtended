using System;
using System.Collections.Generic;
using System.Linq;


namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var grade in grades)
            {
                string name = grade.Key;
                List<double> marks = grade.Value;
                marks.ToString();

                Console.WriteLine("{0} -> {1:f2} (avg: {2:f2})"
                    , name
                    , string.Join(" ", marks.Select(p => string.Format("{0:f2}", p)))
                    , marks.Average());
            }
        }
    }
}
