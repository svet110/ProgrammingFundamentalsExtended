using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Greeting(name);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
