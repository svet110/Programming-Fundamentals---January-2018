namespace WorkingDays
{
    using System;
    using System.Linq;
    using System.Globalization;

    public class WorkDays
    {
        public static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateTime start = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];

            holidays[0] = new DateTime(end.Year, 01, 01);
            holidays[1] = new DateTime(end.Year, 03, 03);
            holidays[2] = new DateTime(end.Year, 05, 01);
            holidays[3] = new DateTime(end.Year, 05, 06);
            holidays[4] = new DateTime(end.Year, 05, 24);
            holidays[5] = new DateTime(end.Year, 09, 06);
            holidays[6] = new DateTime(end.Year, 09, 22);
            holidays[7] = new DateTime(end.Year, 11, 01);
            holidays[8] = new DateTime(end.Year, 12, 24);
            holidays[9] = new DateTime(end.Year, 12, 25);
            holidays[10] = new DateTime(end.Year, 12, 26);

            long workingDays = 0;

            for (var day = start; day <= end; day = day.AddDays(1))
            {
                var currentDate = day;
                var currentDay = day.DayOfWeek;
                if (!holidays.Contains(currentDate) && !currentDay.Equals(DayOfWeek.Saturday) && 
                    !currentDay.Equals(DayOfWeek.Sunday))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
