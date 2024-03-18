using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Lab5
    {
        public static void Test_Lab5()
        {//here you can do stuff related to lab 5
         //   double x;


            Console.WriteLine("Task_521(double[] arrayInput, int k)");
            //   double[] x = { 1.2, 2.1, 3.2, 4.1, 5.2, 6.1, 7.5, 8.3, 9.4, 10.2 };
            int k = 3;



            //  double y = Math.Pow(x,k);
            //    Console.WriteLine(y);

            //Task 522
            static void task_522()
            {
                double[] z = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int sum = 0;
                //    int x = Math.Pow(z, 2);

                for (int i = 0; i < z.Length; i++)
                {
                    //       sum += z[i];
                }

            }
            // Task 523
            static void Task_523()
            {
                Console.WriteLine("Enter a decimal number");
                int a = Convert.ToInt32(Console.ReadLine());
                static int GetNumberOfDigits(decimal a)
                {
                    decimal abs = Math.Abs(a);

                    return abs < 1 ? 0 : (int)(Math.Log10(decimal.ToDouble(abs)) + 1);
                }

            }
            //Task 524
            static void Task_524()
            {
                Console.WriteLine("Enter an integer that is a palindrom, press q to check.");
                // public class PalindromeExample { };
            }

            static void Main(string[] args)
            {
                int num, rev, sum = 0, temp;
                Console.Write("Enter the number: ");
                num = int.Parse(Console.ReadLine());
                temp = num;
                while (num > 0)
                {
                    rev = num % 10;
                    sum = (sum * 10) + rev;
                    num = num / 10;
                }
                if (temp == sum)
                    Console.Write("Yay! the given number is Palindrome.");
                else
                    Console.Write("Oops! the given number is not Palindrome.");
            }
        }
    }
}
   


