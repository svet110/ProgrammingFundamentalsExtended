using System;
using System.Linq;
using System.Collections.Generic;

public class UserLogins
{
    public static void Main()
    {
        var userCredentials = new Dictionary<string, string>();

        string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);


        while (input[0] != "login")
        {
            string user = input[0];
            string pass = input[1];

            userCredentials[user] = pass;

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        int cnt = 0;

        while (input[0] != "end")
        {
            string user = input[0];
            string pass = input[1];

            if (!userCredentials.ContainsKey(user) || userCredentials[user] != pass)
            {
                Console.WriteLine("{0}: login failed", user);
                cnt++;
            }
            else
            {
                Console.WriteLine("{0}: logged in successfully", user);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine("unsuccessful login attempts: {0}", cnt);
    }
}