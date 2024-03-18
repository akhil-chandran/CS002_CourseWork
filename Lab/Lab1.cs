using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Lab1
    {
        public static void Test_lab1()
        {
            Console.WriteLine("Testing the lab1");
            //Do all your programming for lab 1 here

            int myAge = 18;
            Console.WriteLine($"I am {myAge} years old this year.");

            string moduleName = "CS0002";
            string universityName = "Brunel University London";
            Console.WriteLine($"I am studying the {moduleName} module at {universityName}.");

            float interestRate = 0.052f;
            float initialDeposit = 100.50f;
            Console.WriteLine($"Initial Deposit: {initialDeposit}");
            Console.WriteLine($"Interest Rate: {interestRate}");
            Console.WriteLine("Final sum:" + initialDeposit*(1+interestRate));








        }
    }
}
