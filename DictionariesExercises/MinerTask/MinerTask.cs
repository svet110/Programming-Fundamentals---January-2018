namespace MinerTask
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            var resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }

                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}