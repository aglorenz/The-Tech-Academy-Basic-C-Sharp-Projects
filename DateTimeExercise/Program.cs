/*
 * Author:  Andrew Lorenz
 * Date:    1/5/2019
 * Purpose: Demonstrate DateTime usage
 * Req'ts:  Print the current date and time to the console
 *          Query the user for a number
 *          Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.
 */
using System;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime date =  DateTime.Now;
            
            
            Console.WriteLine("\nThe curent date and time is {0}", date);

            // Query the user for a number
            Console.Write("\nEnter a number of hours to which we will add the current date\n>> ");
            int numHours = Convert.ToInt32(Console.ReadLine());

            // Use above user number, add it to the current date/time and print to the console
            //TimeSpan hours = new TimeSpan(5, 0, 0);
            Console.WriteLine("\nThe current date + {0} hours = {1}", numHours, date.AddHours(numHours));
            Console.ReadLine();

        }
    }
}
