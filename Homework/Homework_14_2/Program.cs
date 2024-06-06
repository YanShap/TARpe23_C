namespace Homework_14_2
using System.Globalization;

class TrafficAccidentsAnalyzer
{
    static void Main()
    {
        string[] years = { "1999", "2009", "2019" };
        var accidentsData = new Dictionary<string, int[]>();
        var deathsData = new Dictionary<string, int[]>();
        string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray();

        foreach (var year in years)
        {
            accidentsData[year] = File.ReadAllLines($"{year}_accidents.txt").Select(int.Parse).ToArray();
            deathsData[year] = File.ReadAllLines($"{year}_accidents_Deaths.txt").Select(int.Parse).ToArray();
        }


        var mostAccidents = accidentsData
            .SelectMany(year => year.Value.Select((accidents, month) => new { year.Key, Month = months[month], Accidents = accidents }))
            .OrderByDescending(x => x.Accidents)
            .First();
        Console.WriteLine($"Year and month with most accidents: {mostAccidents.Key} {mostAccidents.Month}: {mostAccidents.Accidents} accidents");

        foreach (var year in years)
        {
            for (int i = 0; i < 12; i++)
            {
                double percentage = (double)deathsData[year][i] / accidentsData[year][i] * 100;
                Console.WriteLine($"{year} {months[i]}: {percentage:F2}%");
            }
        }
        var averageDeathRates = new Dictionary<string, double>();
        foreach (var year in years)
        {
            double averageDeathRate = deathsData[year].Zip(accidentsData[year], (deaths, accidents) => (double)deaths / accidents * 100).Average();
            averageDeathRates[year] = averageDeathRate;
            Console.WriteLine($"{year} average death rate: {averageDeathRate:F2}%");
        }
        var deadliestYear = averageDeathRates.OrderByDescending(x => x.Value).First();
        Console.WriteLine($"Deadliest year: {deadliestYear.Key} with an average death rate of {deadliestYear.Value:F2}%");

        var totalAccidentsPerYear = accidentsData
            .Select(year => new { Year = year.Key, TotalAccidents = year.Value.Sum() })
            .OrderByDescending(x => x.TotalAccidents);
        foreach (var item in totalAccidentsPerYear)
        {
            Console.WriteLine($"{item.Year}: {item.TotalAccidents} accidents");
        }

        var mostDeaths = deathsData
            .SelectMany(year => year.Value.Select((deaths, month) => new { year.Key, Month = months[month], Deaths = deaths }))
            .OrderByDescending(x => x.Deaths)
            .First();
        Console.WriteLine($"Year and month with most deaths: {mostDeaths.Key} {mostDeaths.Month}: {mostDeaths.Deaths} deaths");
    }
}