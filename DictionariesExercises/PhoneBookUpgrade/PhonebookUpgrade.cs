namespace Phonebook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                string[] command = input.Split(' ');
                if (command[0] == "A")
                {
                    string name = command[1];
                    string phoneNumber = command[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNumber;
                    }

                    phonebook[name] = phoneNumber;
                }
                else if (command[0] == "S")
                {
                    string name = command[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
