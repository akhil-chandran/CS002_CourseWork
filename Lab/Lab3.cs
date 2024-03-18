using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab
{
    internal class Lab3
    {
        public static void Test_lab3()
        {
            //here you can call the functions to run the task
            static void Task_22()
            {
                Console.WriteLine("Task2.2");
                Console.WriteLine("input decimal number");
                double w = Double.Parse(Console.ReadLine());
                Math.Round(w);
                Console.WriteLine(w);

                Console.WriteLine("Input 2 lines of string");
                string x = Console.ReadLine();
                string y = Console.ReadLine();


                // static bool isEven();
                Console.WriteLine("Enter a number");
                int Number = int.Parse(Console.ReadLine());
                // isEven(Number);
                Console.WriteLine(Number);


                Console.WriteLine("/n Press any key to quit.");
            }
            // Task 3.3.1 Even/Odd
            static void Task_331()
            {
                Console.WriteLine("Task 3.3.1");

                static bool IsEven(int number)
                { 
                return number % 2 == 0;
                }

                Console.WriteLine("Enter number and I will check if it is even or not.");

                string numberA = Console.ReadLine();
                int number = Convert.ToInt32(numberA);

                if (IsEven(number))
                {
                    Console.WriteLine($"The number {number} is even.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is odd.");
                }


            }       

            //Task 3.3.2 Leap Year
            static void Task_332()
            {
                Console.WriteLine("Task 3.3.2");

                static bool isLeapYear(int number) 
                {
                    return number % 4 == 0;
                }

                Console.WriteLine("Enter a Year and i Will return the Year if it is divisible by 4.");

                string numberA = Console.ReadLine();
                int number = Convert.ToInt32(numberA);

                if (isLeapYear(number))
                {
                    Console.WriteLine($"The year {number} is a leap year");
                }
                else
                {
                    Console.WriteLine($"The year {number} is not a leap year");
                }

            }

            // Task 3.3.3 Days in a month
            static void Task_333()
            {
                Console.WriteLine("Task 3.3.3");

                static bool isLeapYear(int year)
                {
                    return year % 4 == 0;
                }

                Console.WriteLine("Please enter a Year");
                string yearA = Console.ReadLine();
                int year = Convert.ToInt32(yearA);

                Console.WriteLine("Please enter a month.");
                string monthA = Console.ReadLine();
                int month = Convert.ToInt32(monthA);

                switch (month)
                {
                    case 1:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 2:
                        if (isLeapYear(year))
                        {
                            Console.WriteLine("There are 28 days");
                        }
                        else
                        {
                            Console.WriteLine("There are 29 days");
                        }
                        break;
                    case 3:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 4:
                        Console.WriteLine("There are 30 days");
                        break;
                    case 5:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 6:
                        Console.WriteLine("There are 30 days");
                        break;
                    case 7:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 8:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 9:
                        Console.WriteLine("There are 30 days"); 
                        break;
                    case 10:
                        Console.WriteLine("There are 31 days");
                        break;
                    case 11:
                        Console.WriteLine("There are 30 days");
                        break;
                    case 12:
                        Console.WriteLine("There are 31 days");
                        break;
                    default:
                        Console.WriteLine("You have not entered the correct month");
                        break;
                    
                }

            }

            // Task 3.3.4 Factorial (recursive implementation)
            static void task_334()
            {
                int Factorial_num = 0;
                Console.WriteLine("Please enter a number:");
                Factorial_num = Convert.ToInt32(Console.ReadLine());

            }

            // 3.3.5 passing Parameters by Vaalue and Reference
            static void Task_335()
            {
                int inputNumber1 = 100;
                int inputNumber2 = 100;
                Task_436(inputNumber1, ref inputNumber2);
                Console.WriteLine(inputNumber1);
                Console.WriteLine(inputNumber2);

                static void Task_436(int number1, ref int number2)
                {
                    number1 += 1;
                    number2 += 1;
                }

            }

            // 3.4 A simple Menu
            static void Task_34()
            {
                Console.WriteLine("Welcome to Menu");

                static void Function1()
                {
                    Console.WriteLine("This is function 1.");
                }

                static void Function2()
                {
                    Console.WriteLine("This is function 2");
                }

                static void Function3()
                {
                    Console.WriteLine("This is function 3");
                }

                static void Function4()
                {
                    Console.WriteLine("Program termination ... DIIIIIIIEEEEE !!!");
                    Console.ReadLine();
                }
            }
            

        }

    }
}
