using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab
{
    internal class Lab4
    {
        public static void Test_lab4()

        { //This is for task 4.2.1
            Console.WriteLine("Task 4.2.1");
            for (int i = 10; i < 20; i += 3) 
            Console.WriteLine(i);

            //This is for task 4.2.4
            Console.WriteLine("Task 4.2.4 Fibonacci sequence");
            int n1 = 0, n2 = 1, n3,a;
            int Num = 0;
            Console.WriteLine("Please enter how many Fibonacci numbers you want to display?");

            Num = Convert.ToInt32(Console.ReadLine());
            for (a = 2; a < Num; ++a) 
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine(a);

            
            {
                //4.2.5 Using while loop for a simple user interface
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
            // Task 4.3
            static void task_43()
            {
                for (int i = 1; i<= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write(i + " ");
                }
            }

        }
    }
}
