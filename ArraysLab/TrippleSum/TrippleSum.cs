namespace TrippleSum
{
    using System;
    using System.Linq;

    public class TrippleSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool sumContained = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        sumContained = true;                        
                    }
                }
            }

            if (!sumContained)
            {
                Console.WriteLine("No");
            }
        }
    }
}
