using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class StockAnalysis
    {
        public static void GetAnalysis()
        {
            Console.WriteLine("\nStock Analysis Menu");
            Console.WriteLine("1. Yearly data analysis");
            Console.WriteLine("2. Monthly data analysis");
            Console.WriteLine("3. Exit to main menu");

            Console.Write("\nEnter your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    YearlyDataAnalysis();
                    break;
                case "2":
                    MonthlyDataAnalysis();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("\nInvalid choice.");
                    return;
            }
        }

        static void YearlyDataAnalysis()
        {
            string[] tradingData = File.ReadAllLines("D:\\Temp\\TradingData.csv");
            if (tradingData.Length != 0)
            {
                double openingPrice = double.Parse(tradingData[1].Split(',')[1]);
                double closingPrice = double.Parse(tradingData.Last().Split(',')[4]);
                double highestPrice = tradingData.Skip(1).Select(data => double.Parse(data.Split(',')[2])).Max();
                double lowestPrice = tradingData.Skip(1).Select(data => double.Parse(data.Split(',')[3])).Min();
                var maxVolumeData = tradingData.Skip(1).Select(data => new { Date = DateTime.ParseExact(data.Split(',')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture), Volume = int.Parse(data.Split(',')[5]) }).OrderByDescending(x => x.Volume).First();

                Console.WriteLine("\n");
                Console.WriteLine("Total number of trading days: " + (tradingData.Length - 1));
                Console.WriteLine("Opening price of the first trading day: " + openingPrice.ToString("F2"));
                Console.WriteLine("Closing price of the last trading day: " + closingPrice.ToString("F2"));
                Console.WriteLine("Highest trading price of the year: " + highestPrice.ToString("F2"));
                Console.WriteLine("Lowest trading price of the year: " + lowestPrice.ToString("F2"));
                Console.WriteLine("Date with the highest trading volume: " + maxVolumeData.Date.ToString("dd/MM/yyyy") + ", closing price change from the previous trading day: " + ((closingPrice - double.Parse(tradingData[tradingData.Length - 2].Split(',')[4], CultureInfo.InvariantCulture)) / closingPrice * 100).ToString("F1") + "%");
            }
            else
            {
                Console.WriteLine("No data available");
            }
        }

        static void MonthlyDataAnalysis()
        {
            Console.Write("\nEnter one month in format (Jan, Feb, Mar...): ");
            string month = Console.ReadLine();

            string[] tradingData = File.ReadAllLines("D:\\Temp\\TradingData.csv");
            if (tradingData.Length != 0)
            {
                var monthData = tradingData.Skip(1).Where(data => DateTime.ParseExact(data.Split(',')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MMM") == month);

                if (monthData.Any())
                {
                    double openingPrice = double.Parse(monthData.First().Split(',')[1], CultureInfo.InvariantCulture);
                    double closingPrice = double.Parse(monthData.Last().Split(',')[4], CultureInfo.InvariantCulture);
                    double highestPrice = monthData.Select(data => double.Parse(data.Split(',')[2], CultureInfo.InvariantCulture)).Max();
                    double lowestPrice = monthData.Select(data => double.Parse(data.Split(',')[3], CultureInfo.InvariantCulture)).Min();
                    var top3Data = monthData.Select(data => new { Date = DateTime.ParseExact(data.Split(',')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture), Volume = int.Parse(data.Split(',')[5]) }).OrderByDescending(x => x.Volume).Take(3);

                    Console.WriteLine("\n");
                    Console.WriteLine("Selected Month: " + month);
                    Console.WriteLine("Opening price: " + openingPrice.ToString("F2"));
                    Console.WriteLine("Closing price: " + closingPrice.ToString("F2"));
                    Console.WriteLine("Highest trading price: " + highestPrice.ToString("F2"));
                    Console.WriteLine("Lowest trading price: " + lowestPrice.ToString("F2"));
                    Console.WriteLine("The three dates with the highest trading volume (in descending order): " + string.Join(", ", top3Data.Select(x => x.Date.ToString("dd/MM/yyyy"))));
                }
                else
                {
                    Console.WriteLine("\nNo data for month : " + month);
                }
            }
            else
            {
                Console.WriteLine("\nNo data available");
            }
        }
    }
}
