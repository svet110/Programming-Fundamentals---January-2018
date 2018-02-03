namespace SearchForANumber
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SearchForANumber
    {
        public static void Main()
        {
            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numbersToTake = arr[0];
            int numbersToDelete = arr[1];
            int numberToSearch = arr[2];

            listOfIntegers = listOfIntegers.Take(numbersToTake).ToList();
            for (int i = 0; i < numbersToDelete; i++)
            {
                listOfIntegers.RemoveAt(i - i);
            }

            if (listOfIntegers.Contains(numberToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
