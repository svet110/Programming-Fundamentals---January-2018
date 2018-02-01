namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumEquals
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
