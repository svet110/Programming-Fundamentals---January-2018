namespace _03FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            // Reading an array from the console and finding 'k':
            int[] numbers = Console.ReadLine().Split( ' ' ).Select(int.Parse).ToArray();
            int k = numbers.Length / 4; //..

            // Splitting int[] numbers into pieces:
            int[] leftPiece = numbers.Take(k).ToArray();
            int[] middlePiece = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightPiece = numbers.Skip(k * 3).Take(k).ToArray(); //...

            // Reversing left and right pieces:
            Array.Reverse(leftPiece);
            Array.Reverse(rightPiece); // ..

            // Sum left and right pieces with the middle piece and store the result into int[] result:
            int[] result = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftPiece[i] + middlePiece[i];
                result[i + k] = rightPiece[i] + middlePiece[i + k];
            }

            // Printing the result:
            Console.WriteLine(string.Join(" ", result)); //..
        }
    }
}
