using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }

    public class Exercises
    {
        public static void Main()
        {
            var exercises = new List<Exercise>();

            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] inputLine = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputLine[0];
                string courseName = inputLine[1];
                string judgeContestLink = inputLine[2];
                List<string> problems = inputLine.Skip(3).ToList();

                Exercise newExercise = new Exercise();

                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;

                exercises.Add(newExercise);

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                int num = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", num, problem);
                    num++;
                }
            }
        }
    }
}
