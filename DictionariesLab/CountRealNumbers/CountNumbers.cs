namespace CountRealNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var numbers = new SortedDictionary<double, int>();           

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                double current = arrayOfNumbers[i];
                if (!numbers.ContainsKey(current))
                {
                    numbers[current] = 0;
                }

                numbers[current]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
