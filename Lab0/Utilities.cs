using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    /// <summary>
    /// Methods for getting and validating input data and relevant calculation
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// reads positive decimal
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>decimal value read that is >0</returns>
        public static decimal GetPositiveDecimal(string prompt)
        {
            bool gotIt = false;
            decimal result = 0;
            string input;

            while (!gotIt) //while not gotIt (while gotIt is false)
            {
                Console.WriteLine($"Enter {prompt}:"); //interpolated string
                input = Console.ReadLine() ?? ""; // null coalescing operator
                // TryParse attempts to parse the string first argument
                // returns false (instead of crashing) when cannot do
                //returns true and assigns the second arg variable if successful
                if (Decimal.TryParse(input, out result))  // result is assigned the parsed value
                {
                    if (result > 0)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else // could not parse
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                }
            }


            return result;
        }

    

      /// <summary>
        /// reads positive decimal
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>decimal value read that is >0</returns>
        public static double GetPositiveInt(string prompt)
        {
            bool gotIt = false;
            double result = 0;
            string input;

            while (!gotIt) //while not gotIt (while gotIt is false)
            {
                Console.WriteLine($"Enter {prompt}:"); //interpolated string
                input = Console.ReadLine() ?? ""; // null coalescing operator
                // TryParse attempts to parse the string first argument
                // returns false (instead of crashing) when cannot do
                //returns true and assigns the second arg variable if successful
                if (Double.TryParse(input, out result))  // result is assigned the parsed value
                {
                    if (result > 0)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else // could not parse
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }


            return result;
        }

        /// <summary>
        /// reads positive decimal
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>decimal value read that is >0</returns>        
        public static double GetIntInRange(string prompt, double minValue, double maxValue) {
            bool gotIt = false;
            double result = 0;
            string input;

            while (!gotIt) //while not gotIt (while gotIt is false)
            {
                Console.WriteLine($"Enter {prompt}:"); //interpolated string
                input = Console.ReadLine() ?? ""; // null coalescing operator
                // TryParse attempts to parse the string first argument
                // returns false (instead of crashing) when cannot do
                //returns true and assigns the second arg variable if successful
                if (Double.TryParse(input, out result))  // result is assigned the parsed value
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        if (minValue == Int32.MinValue)
                            Console.WriteLine($"Error: {prompt} must be positive");
                        if (maxValue <= minValue)
                            Console.WriteLine();
                    }
                }
                else // could not parse
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }


            return result;
        } 

        public static bool GetPrimeNumber(double number )
        {
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            if (prime)
            {
                Console.WriteLine(number);
            }
            return prime;
           
        }

    }
    }
