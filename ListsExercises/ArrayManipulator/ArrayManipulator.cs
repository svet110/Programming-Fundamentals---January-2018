namespace ArrayManipulator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();            
            while (command != "print")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0];                
                switch (action)
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);
                        list.Insert(index, element);
                        break;

                    case "addMany":
                        int indexToAddRangeFrom = int.Parse(tokens[1]);
                        var rangeToAdd = new List<int>();
                        for (int i = 2; i < tokens.Length; i++)
                        {
                            rangeToAdd.Add(int.Parse(tokens[i]));
                        }
                        list.InsertRange(indexToAddRangeFrom, rangeToAdd);
                        break;

                    case "contains":
                        element = int.Parse(tokens[1]);
                        if (list.Contains(element))
                        {
                            Console.WriteLine(list.IndexOf(element));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }

                        break;

                    case "remove":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemoveAt);
                        break;

                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        ShiftPositions(list, positions);
                        break;

                    default:
                        SumPairsInList(list);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        public static void SumPairsInList(List<int> list)
        {
            if (list.Count % 2 == 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int sum = list[i + 1] + list[i];
                    list[i] = sum;
                    list.RemoveAt(i + 1);
                }
            }
            else
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    int sum = list[i + 1] + list[i];
                    list[i] = sum;
                    list.RemoveAt(i + 1);
                }
            }            
        }

        public static void ShiftPositions(List<int> list, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                int temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
        }
    }
}
