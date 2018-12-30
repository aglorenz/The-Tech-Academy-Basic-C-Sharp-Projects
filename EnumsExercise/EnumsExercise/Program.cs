/*
 * Author:  Andrew Lorenz
 * Date:    12/30/2018
 * Purpose: Demonstrate Enums and how to pars
 * Req'ts:  Create an enum for the days of the week.  Prompt the user to enter the current day of the week.
 *          Assign the value to a variable of that enum data type you just created.  Wrap the above statement 
 *          in a try/catch block and have it print "Please enter an actual day of the week." to the console 
 *          if an error occurs
 */

using System;

namespace EnumsExercise
{
    class Program
    {
        // Create an enum for the days of the week.
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                // List the days of the week from the enum type 
                Console.WriteLine("The days of the week are:\n");
                for (int i=0; i<7; i++)
                {
                    Console.WriteLine((DaysOfWeek) i );
                }

                // Ask user to enter the current day of the week
                Console.Write("\nEnter the current day of the week \n>> ");
                string dayString = Console.ReadLine();

                // Assign the value to a variable of that enum data type just created.
                // (Parse the enum to see if it's a day of the week)
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayString);

                Console.WriteLine("\nYou entered {0}", day);
                Console.WriteLine("It's integer equivalent is {0}", (int)day);
                Console.ReadLine();

                //Console.WriteLine(Enum.Parse(typeof(DaysOfWeek), dayString));
                //Console.WriteLine(DaysOfWeek.Friday);
                //int myDay = (int)Enum.Parse(typeof(DaysOfWeek), dayString);
                //Console.WriteLine(myDay);

                //if (Enum.TryParse<DaysOfWeek>(dayString, out day))
                //{
                //    Console.WriteLine("You entered {0}", day);
                //    Console.ReadLine();
                //}

            }
            catch (SystemException ex)
            {
                Console.WriteLine("\nError: Please enter an actual day of the week. " + ex.Message);
                Console.ReadLine();
            }
        }

    }
}
