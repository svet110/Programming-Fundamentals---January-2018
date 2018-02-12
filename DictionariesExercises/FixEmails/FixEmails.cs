namespace FixEmails
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            var emails = new Dictionary<string, string>();

            while (true)
            {
                if (!email.EndsWith("us", StringComparison.InvariantCultureIgnoreCase) 
                    && !email.EndsWith("uk", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!emails.ContainsKey(name))
                    {
                        emails[name] = email;
                    }

                    emails[name] = email;
                }
                
                name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                email = Console.ReadLine();
            }

            foreach (var mail in emails)
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}
