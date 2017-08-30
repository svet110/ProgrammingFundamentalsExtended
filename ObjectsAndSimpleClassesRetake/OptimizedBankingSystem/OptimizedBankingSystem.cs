using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var accounts = new List<BankAccount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                string bank = tokens[0];
                string name = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                var newAccount = new BankAccount()
                {
                    Bank = bank,
                    Name = name,
                    Balance = balance
                };

                accounts.Add(newAccount);

                input = Console.ReadLine();
            }

            var sortedAccounts = accounts.OrderByDescending(acc => acc.Balance).ThenBy(acc => acc.Bank.Length);

            foreach (var account in sortedAccounts)
            {
                Console.WriteLine("{0} -> {1} ({2})", account.Name, account.Balance, account.Bank);
            }
        }
    }
}
