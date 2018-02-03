namespace ChangeList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeList
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();            
            while (command != "Odd" && command != "Even")
            {
                string[] tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int element = int.Parse(tokens[1]);
                if (tokens.Length < 3)
                {
                    list.RemoveAll(x => x == element);
                }
                else
                {
                    int position = int.Parse(tokens[2]);
                    list.Insert(position, element);
                }

                command = Console.ReadLine();
            }

            if (command == "Odd")
            {
                var result = list.Where(e => e % 2 != 0).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = list.Where(e => e % 2 == 0).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
