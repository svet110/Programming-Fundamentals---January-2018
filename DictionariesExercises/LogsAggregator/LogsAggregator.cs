namespace LogsAggregator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LogsAggregator
    {
        public static void Main()
        {
            var usersData = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ipAdress = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!usersData.ContainsKey(user))
                {
                    usersData[user] = new SortedDictionary<string, int>();
                }
                if (!usersData[user].ContainsKey(ipAdress))
                {
                    usersData[user][ipAdress] = duration;
                }
                else
                {
                    usersData[user][ipAdress] += duration;
                }                                
            }

            foreach (var userData in usersData)
            {                
                var totalDurationOfUser = usersData[userData.Key].Values.Sum();
                var listOfIps = userData.Value.Keys.ToList();
                Console.WriteLine($"{userData.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
