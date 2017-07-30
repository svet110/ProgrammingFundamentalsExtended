using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            string jsonText = Console.ReadLine();

            string[] studentLine = jsonText.Trim('[')
                .Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < studentLine.Length; i++)
            {
                string student = studentLine[i];
                student = student
                    .Replace(":[]", ":[None]")
                    .Replace("]", string.Empty)
                    .Replace("\"", string.Empty)
                    .Replace("{", string.Empty)
                    .Replace("}", string.Empty)
                    .Replace("name:", string.Empty)
                    .Replace(",age:", " : ")
                    .Replace(",grades:[", " -> ")
                    .Replace("]}", string.Empty);


                Console.WriteLine(student);
            }
        }
    }
}
