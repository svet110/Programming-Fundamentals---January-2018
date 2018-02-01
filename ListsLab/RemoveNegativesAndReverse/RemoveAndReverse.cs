namespace RemoveNegativesAndReverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();
            numbers = numbers.Where(x => x > 0).ToList();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}