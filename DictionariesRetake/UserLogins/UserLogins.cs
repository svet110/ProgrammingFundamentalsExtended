using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            var users = new Dictionary<string, string>();
            var usersAndPasswords = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            
            while (usersAndPasswords[0] != "login")
            {
                string user = usersAndPasswords[0];
                string password = usersAndPasswords[1];

                if (!users.ContainsKey(user))
                {
                    users[user] = password;
                }
                users[user] = password;

                usersAndPasswords = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            var logins = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (logins[0] != "end")
            {
                string userLogging = logins[0];
                string passwordLogging = logins[1];

                if (!users.ContainsKey(userLogging) || users[userLogging] != passwordLogging)
                {
                    counter++;
                    Console.WriteLine("login failed");                    
                }
                else
                {
                   Console.WriteLine("{0} logged in successfully", userLogging);
                }

                logins = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

           Console.WriteLine("unsuccessful login attempts: {0}", counter);           
        }
    }
}
