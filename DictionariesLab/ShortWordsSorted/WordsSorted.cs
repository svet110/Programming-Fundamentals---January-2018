namespace ShortWordsSorted
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class WordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var shortWords = new List<string>();

            foreach (var word in text)
            {
                if (word.Length < 5)
                {
                    shortWords.Add(word);
                }
            }

            var result = shortWords
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
