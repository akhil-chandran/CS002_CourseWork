using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Coursework
    {
        public static void Test_coursework()
        {
            string userInput = "";
            do
            {
                // Program Menu
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Find Minimum/Maximum");
                Console.WriteLine("2. Stock Analysis");
                Console.WriteLine("3. Exit");

                Console.Write("\nPlease input your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CubicFunction.CalculateCubicFunction();
                        break;
                    case "2":
                        StockAnalysis.GetAnalysis();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("\nThis is not a valid input");
                        break;
                }
            }
            while (userInput != "3");
        }

        // This program is designed to find the min/max of a function.
        static void Menu_program()
        {
            static void Function1()
            {
                Console.WriteLine("Find minimum/Maximum");
                String InputA = Console.ReadLine();
                int UserInputA = Convert.ToInt32(InputA);

                String InputB = Console.ReadLine();
                int UserInputB = Convert.ToInt32(InputB);

                String InputC = Console.ReadLine();
                int UserInputC = Convert.ToInt32(InputC);

                String InputD = Console.ReadLine();
                int UserInputD = Convert.ToInt32(InputD);

                // allows users to input into cubic equation.


            }

            static void Function2()
            {
                Console.WriteLine("Stock Analysis");

                // The following code reads data from the CSV file.
                List<int> StockData = new List<int>();
                using (StreamReader sr = new StreamReader(@"AMD.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] tempStrings = line.Split(",");
                        int Stock = 0;
                        Int32.TryParse(tempStrings[1], out Stock);
                        StockData.Add(Stock);
                    }
                }
            }

            static void Function3()
            {
                Console.WriteLine("Exit");

            }
        }

    }
}
