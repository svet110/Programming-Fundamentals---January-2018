namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseArray
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] reversedArr = new string[arr.Length];
            
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}
