namespace LargestThreeNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LargestThree
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();

            list = list.Take(3).ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
