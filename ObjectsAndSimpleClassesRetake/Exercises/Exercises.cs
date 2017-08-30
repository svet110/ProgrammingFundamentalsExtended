using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercises
    {
        public static void Main()
        {
            var exercises = new List<Exercise>();

            string command = Console.ReadLine();

            while (command != "go go go")
            {
                string[] tokens = command.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeContestLink = tokens[2];
                List<string> problems = tokens.Skip(3).ToList();

                Exercise newExercise = new Exercise()
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContesLink = judgeContestLink,
                    Problems = problems
                };

                exercises.Add(newExercise);

                command = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                int counter = 1; 
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.",
                    exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}.", exercise.JudgeContesLink);

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", counter, problem);
                    counter++;
                }                
            }
        }
    }
}
