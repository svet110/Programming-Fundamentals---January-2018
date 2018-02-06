namespace SumReversedNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumReversed
    {
        public static void Main()
        {
            List<string> numsAsStrings = Console.ReadLine().Split(' ').ToList();
            List<int> reversed = new List<int>();

            for (int i = 0; i < numsAsStrings.Count; i++)
            {
                string number = numsAsStrings[i];
                string reversedStr = reverseTheString(number);
                int num = int.Parse(reversedStr);
                reversed.Add(num);
            }
            Console.WriteLine(reversed.Sum());
        }

        public static string reverseTheString(string number)
        {
            char[] arr = number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
    }
}
