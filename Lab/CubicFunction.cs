using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class CubicFunction
    {
        public static void CalculateCubicFunction()
        {
            Console.WriteLine("\nAppendix B - Finding local minimum or maximum of a cubic function");

            // Input coefficients of the cubic function: ax^3 + bx^2 + cx + d
            Console.WriteLine("\nEnter the coefficients a, b, c, d : ");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            double valueA = 3 * a;
            double valueB = 2 * b;
            double valueC = c;
            double valueD = d;

            //Use the discriminant ((2𝑏)^2 − 4 ∗ (3𝑎) ∗ 𝑐 ) of the 𝑥𝑟𝑜𝑜t
            double discriminant = valueB * valueB - 4 * valueA * valueC;

            //If the discriminant is less than zero, no real root can be found. The program should return a proper message, 
            //e.g. "No minimum/maximum can be found".The program should then return to the main “Menu” of the
            //coursework.
            if (discriminant < 0)
            {
                Console.WriteLine("\nNo minimum/maximum can be found.");
                return;
            }

            //Calculating
            //𝑥𝑟𝑜𝑜𝑡 = −2𝑏 ± √(2𝑏)2−4∗(3𝑎)∗𝑐 / 2* (3a) ------------(3)

            double Xroot1 = (-valueB + Math.Sqrt(discriminant)) / (2 * valueA);
            double Xroot2 = (-valueB - Math.Sqrt(discriminant)) / (2 * valueA);

            double secondDerivativeXroot1 = 6 * a * Xroot1 + 2 * b;
            double secondDerivativeXroot2 = 6 * a * Xroot2 + 2 * b;

            //If the discriminant is great than zero (two roots)
            if (discriminant > 0)
            {
                if (secondDerivativeXroot1 > 0)
                {
                    double min = a * Xroot1 * Xroot1 * Xroot1 + b * Xroot1 * Xroot1 + c * Xroot1 + valueD;
                    Console.WriteLine($"The minimum is at (X = {Xroot1}, f(X) = {min})");
                }
                else if (secondDerivativeXroot1 < 0)
                {
                    double max = a * Xroot1 * Xroot1 * Xroot1 + b * Xroot1 * Xroot1 + c * Xroot1 + valueD;
                    Console.WriteLine($"The maximum is at (X = {Xroot1}, f(X) = {max})");
                }
                else
                {
                    Console.WriteLine("The function might have an inflection point.");
                }

                if (secondDerivativeXroot2 > 0)
                {
                    double min = a * Xroot2 * Xroot2 * Xroot2 + b * Xroot2 * Xroot2 + c * Xroot2 + valueD;
                    Console.WriteLine($"The minimum is at (X = {Xroot2}, f(X) = {min})");
                }
                else if (secondDerivativeXroot2 < 0)
                {
                    double max = a * Xroot2 * Xroot2 * Xroot2 + b * Xroot2 * Xroot2 + c * Xroot2 + valueD;
                    Console.WriteLine($"The maximum is at (X = {Xroot2}, f(X) = {max})");
                }
                else
                {
                    Console.WriteLine("The function might have an inflection point.");
                }
            }
            else //If the discriminant is equal to ZERO(one root)
            {
                if (secondDerivativeXroot1 > 0)
                {
                    double min = a * Xroot1 * Xroot1 * Xroot1 + b * Xroot1 * Xroot1 + c * Xroot1 + valueD;
                    Console.WriteLine($"The minimum is at (X = {Xroot1}, f(X) = {min})");
                }
                else if (secondDerivativeXroot1 < 0)
                {
                    double max = a * Xroot1 * Xroot1 * Xroot1 + b * Xroot1 * Xroot1 + c * Xroot1 + valueD;
                    Console.WriteLine($"The maximum is at (X = {Xroot1}, f(X) = {max})");
                }
                else
                {
                    Console.WriteLine("The function might have an inflection point.");
                }
            }
        }
    }
}

