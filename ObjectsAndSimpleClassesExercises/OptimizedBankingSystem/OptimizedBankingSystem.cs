using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankingSystem
{
    public class Account
    { 
        public string Name { get; set; } 
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public Account(string bank, string name, decimal balance)
        {
            this.Bank = bank;
            this.Name = name;
            this.Balance = balance;
        }
    }
    
    class OptimizedBankingSystem
    {
        static void Main()
        {
            List<Account> accounts = new List<Account>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] accountsInput = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = accountsInput[0];
                string name = accountsInput[1];
                decimal balance = decimal.Parse(accountsInput[2]);

                Account account = new Account(bank, name, balance);                         

                accounts.Add(account);                                             

                input = Console.ReadLine();
            }

            var orderedData = accounts.OrderByDescending(b => b.Balance)
                .ThenBy(n => n.Bank.Length);

            foreach (var data in orderedData)
            {
                Console.WriteLine("{0} -> {1} ({2})", data.Name, data.Balance, data.Bank);
            }
        }
    }
}
