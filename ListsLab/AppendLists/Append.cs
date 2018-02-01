namespace AppendLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Append
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            tokens.Reverse();

            var result = new List<string>();

            foreach (var token in tokens)
            {
                var numsAsStrings = token.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(numsAsStrings);                
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
