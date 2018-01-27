namespace AwayFromZero
{
    using System;
    using System.Linq;

    public class RoundingAwayFromZero
    {
        public static void Main()
        {
            double[] values = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            for (int i = 0; i < values.Length; i++)
            {
                double currentValue = values[i];
                Console.WriteLine($"{currentValue} => {Math.Round(currentValue, MidpointRounding.AwayFromZero)}");  
            }
        }
    }
}