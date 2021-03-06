﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    public class JSONStringify
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            StringBuilder result = new StringBuilder("[");

            string input = Console.ReadLine();
            while (input != "stringify")
            {
                string[] tokens = input.Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0].Trim();
                int age = int.Parse(tokens[1].Trim());
                List<int> grades = tokens.Skip(2).Select(int.Parse).ToList();

                Student newStudent = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };

                students.Add(newStudent);

                input = Console.ReadLine();
            }

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                result.Append("{name:\"" + student.Name + "\",age:" + student.Age + ",grades:[");
                result.Append(string.Join(", ", student.Grades) + "]}");
                if (i < students.Count - 1)
                {
                    result.Append(",");
                }
            }

            result.Append("]");

            Console.WriteLine(result.ToString());
        }
    }
}