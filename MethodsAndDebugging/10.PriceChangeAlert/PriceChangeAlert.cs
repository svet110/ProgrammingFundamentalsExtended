using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PriceChangeAlert
{
    class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold =
            double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = percentage(lastPrice, currentPrice);
                bool isSignificantDifference = IsThereADifference(difference, significanceThreshold);
                string message = GetOutputMessageForChanges(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        public static string GetOutputMessageForChanges
            (double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string outputMessage = string.Empty;

            if (difference == 0)
            {
                outputMessage = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                outputMessage = string.Format
                    ("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                outputMessage = string.Format
                    ("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
                outputMessage = string.Format
                    ("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            return outputMessage;
        }

        public  static bool IsThereADifference(double significanceThreshold, double difference)
        {
            if (Math.Abs(significanceThreshold) >= difference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double percentage(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
