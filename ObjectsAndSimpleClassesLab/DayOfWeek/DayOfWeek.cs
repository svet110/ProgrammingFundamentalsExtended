using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(
              dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
