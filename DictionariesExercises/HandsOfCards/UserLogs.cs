namespace UserLogs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UserLogs
    {
        public static void Main()
        {
            var usersData = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string[] ipTokens = tokens[0].Split('=').ToArray();
                string[] userTokens = tokens[2].Split('=').ToArray();
                string ipAdress = ipTokens[1];                
                string user = userTokens[1];

                if (!usersData.ContainsKey(user))
                {
                    usersData[user] = new Dictionary<string, int>();                                       
                }
                if (!usersData[user].ContainsKey(ipAdress))
                {
                    usersData[user][ipAdress] = 0;
                }
                usersData[user][ipAdress]++;

                input = Console.ReadLine();
            }

            foreach (var user in usersData)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var ipAdress in user.Value)
                {
                    if (ipAdress.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ipAdress.Key} => {ipAdress.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ipAdress.Key} => {ipAdress.Value}.");
                    }
                }
            }
        }        
    }
}
