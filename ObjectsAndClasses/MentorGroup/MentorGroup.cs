namespace MentorGroup
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;

    public class MentorGroup
    {
        public static void Main()
        {
            var listOfDates = new List<DateTime>();
            var listOfComments = new List<string>();
            var users = new SortedDictionary<string, User>();
            string userName = string.Empty;

            string line = Console.ReadLine();
            while (line != "end of dates")
            {
                string[] usersAndDates = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                userName = usersAndDates[0];

                if (usersAndDates.Length > 1)
                {                    
                    for (int i = 1; i < usersAndDates.Length; i++)
                    {
                        DateTime currentDate = DateTime.ParseExact(usersAndDates[i], "dd/MM/yyyy"
                            , CultureInfo.InvariantCulture);

                        listOfDates.Add(currentDate);
                    }

                    User newUser = new User
                    {
                        Dates = listOfDates                        
                    };

                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName, newUser);
                        newUser.Dates = listOfDates;
                    }
                    else
                    {
                        users[userName].Dates.AddRange(listOfDates);
                    }
                }

                line = Console.ReadLine();
            }

            string anotherLine = Console.ReadLine();
            while (anotherLine != "end of comments")
            {
                string[] usersAndComments = anotherLine.Split('-');                

                if (usersAndComments.Length > 1)
                {
                    for (int i = 1; i < usersAndComments.Length; i++)
                    {
                        string currentComment = usersAndComments[i];
                        listOfComments.Add(currentComment);
                    }

                    if (users.ContainsKey(userName))
                    {
                        if (users[userName].Comments != null)
                        {
                            users[userName].Comments.AddRange(listOfComments);
                        }
                        else
                        {
                            users[userName].Comments = listOfComments;
                        }
                    }
                }

                anotherLine = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}");
                Console.WriteLine("Comments:");
                if (user.Value.Comments != null)
                {
                    foreach (var comment in user.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }               

                Console.WriteLine("Dates attended:");
                foreach (var date in user.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date}");
                }
            }
        }
    }
}
