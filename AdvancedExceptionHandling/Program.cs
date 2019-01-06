/*
 * Author:  Andrew Lorenz
 * Date:    1/5/2019
 * Purpose: Demonstrate more advanced exception handling
 * Req'ts:  Ask the user for their age
 *          Display the year user was born
 *          Exceptions must be handled using "try .. catch".
 *          Display appropriate error message if user enters zero or negative numbers.
 *          Display a general message if exception caused by anything else
 */
 using System;

namespace AdvancedExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for their age
                Console.Write("What is your age?\n>> ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) throw new NegativeOrZeroException();

                // Display year in which user was born (give or take 1 year)
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - age;
                Console.WriteLine("\nYou were born in the year {0} or {1}", yearBorn, yearBorn-1);
                Console.ReadLine();
            }
            // Catch user age input that is <= 0
            catch (NegativeOrZeroException)
            {
                Console.WriteLine("\nYour age must be greater than 0.");
                Console.ReadLine();
            }
            // Catch any other more general exceptions
            catch (Exception)
            {
                Console.WriteLine("\nAn error occurred. Please enter only digits with no decimal point.");
                Console.ReadLine();
            }

        }
    }
}