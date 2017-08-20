using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNumber = int.Parse(Console.ReadLine());
            GetDayOfWeek(dayNumber, daysOfWeek);
        }

        public static void GetDayOfWeek(int dayNumber, string[] daysOfWeek)
        {
            if (dayNumber > 0 && dayNumber < 8)
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }        
    }
}
