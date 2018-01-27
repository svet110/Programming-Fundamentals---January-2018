namespace _01LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnds
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCounter = GetMaxCommonEnd(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int rightCounter = GetMaxCommonEnd(firstArray, secondArray);
            int result = Math.Max(leftCounter, rightCounter);

            Console.WriteLine(result);
        }

        public static int GetMaxCommonEnd(string[] firstArray, string[] secondArray)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            int counter = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}