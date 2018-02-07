namespace SumMinMaxAverage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                listOfNumbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = {0}", listOfNumbers.Sum());
            Console.WriteLine("Min = {0}", listOfNumbers.Min());
            Console.WriteLine("Max = {0}", listOfNumbers.Max());
            Console.WriteLine("Average = {0}", listOfNumbers.Average());
        }
    }
}
