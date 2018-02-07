namespace OddOccurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i]))
                {
                    dict[words[i]] = 0;
                }

                dict[words[i]]++;
            }

            var result = new List<string>();

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
