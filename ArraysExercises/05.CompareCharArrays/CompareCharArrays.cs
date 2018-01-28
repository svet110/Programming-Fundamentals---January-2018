namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int minLenght = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    if (firstArr.Length <= secondArr.Length)
                    {
                        Console.WriteLine(string.Join("", firstArr));
                        Console.WriteLine(string.Join("", secondArr));
                        break;
                    }
                    else if (firstArr.Length > secondArr.Length)
                    {
                        Console.WriteLine(string.Join("", secondArr));
                        Console.WriteLine(string.Join("", firstArr));
                        break;
                    }                    
                }
                else
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        if (firstArr.Length <= secondArr.Length)
                        {
                            Console.WriteLine(string.Join("", firstArr));
                            Console.WriteLine(string.Join("", secondArr));
                            break;
                        }
                        else 
                        {
                            Console.WriteLine(string.Join("", secondArr));
                            Console.WriteLine(string.Join("", firstArr));
                            break;
                        }                        
                    }
                    else
                    {
                        if (firstArr.Length < secondArr.Length)
                        {
                            Console.WriteLine(string.Join("", firstArr));
                            Console.WriteLine(string.Join("", secondArr));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", secondArr));
                            Console.WriteLine(string.Join("", firstArr));
                            break;
                        }
                    }
                }
            }
        }
    }
}
