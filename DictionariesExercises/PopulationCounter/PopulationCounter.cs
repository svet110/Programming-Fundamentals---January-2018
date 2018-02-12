namespace PopulationCounter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class PopulationCounter
    {
        public static void Main()
        {
            var populationData = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] data = input.Split('|');
                string country = data[1];
                string city = data[0];
                long population = long.Parse(data[2]);

                if (!populationData.ContainsKey(country))
                {
                    populationData[country] = new Dictionary<string, long>();
                }
                if (!populationData[country].ContainsKey(city))
                {
                    populationData[country][city] = population;
                }
                else
                {
                    populationData[country][city] += population;
                }

                input = Console.ReadLine();
            }

            foreach (var country in populationData.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
