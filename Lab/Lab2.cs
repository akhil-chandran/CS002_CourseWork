using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Lab2
    {
        // this is the entry point of Lab2 tasks, the following function
        // should be called in the Main function in Program.cs
        public static void Test_lab2()
        {
            Console.WriteLine("Testing lab 2 tasks!\n");
            //You should type in all the codes for lab 2 tasks here
         static void task_22()
                {
                Console.WriteLine("Task2.2 Assignment and expression");
                }
            static void task_23()
            {
                Console.WriteLine("2.3:Vaiables and Expressions");
                int a = 5;
                double b = 2.3;
                double c = 1.2;
                int p = 3;
                String f = "a student!";
                String name = "you can type in your name here";
                double pi = 3.142;

                long x;
                double y;
                string z;

                x = (long)(a + b);
                Console.WriteLine("1) x = a+b");
                Console.WriteLine($"Result: {x}");
            }
            // task 241
            static void task_241()
            {
                Console.WriteLine("Task 2.4.1: Relational Operator");
                int m = 100;
                int n = 204;
                double o = -23.1;
                Boolean s = true;
                Boolean q = false;
                int r = -204;

                Console.WriteLine("1) Is m < n?");
                if (m < n)
                    Console.WriteLine("m<n: True");
                else
                    Console.WriteLine("m<n: False");
            }
            // coding for Task_242
            static void Task_242()
            {
                Console.WriteLine("Task 2.4.2");
                Console.WriteLine("Input an ID number");
                string UserID = Console.ReadLine();
                int UserIDa = Convert.ToInt32(UserID);
                if (UserIDa == 20)
                    Console.WriteLine("ID starts with 20");
                if (UserIDa == 30)
                    Console.WriteLine("ID starts with 30");
                if (UserIDa == 40)
                    Console.WriteLine("ID starts with 40");
                else
                    Console.WriteLine("Incorrect Employee Number");

            }
        }
        // Task 2.4.3
        static void Task_243()
        {
            Console.WriteLine("Task 2.4.3");
            Console.WriteLine("Input any number");
            string UserInp = Console.ReadLine();
            int UserInpA = Convert.ToInt32(UserInp);

            switch (UserInpA)
            {
                case < 10:
                    Console.WriteLine("Input is less than 10.");
                    break;
                case >= 90:
                    Console.WriteLine("Input is greater than or equal to 90.");
                    break;
                case >= 30 and <= 40:
                    Console.WriteLine("Input is between 30 and 40.");
                    break;
                default:
                    Console.WriteLine("Not in any category");
                    break;
            }
        }
    }

}
