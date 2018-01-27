namespace LastKElementsSum
{
    using System;

    public class LastKElementsSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (i - j >= 0)
                    {
                        array[i] += array[i - j];
                        continue;
                    }

                    break;
                }                
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
