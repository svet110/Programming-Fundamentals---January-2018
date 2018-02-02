namespace SortNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Sort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
