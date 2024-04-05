using System;


namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask the user for their age.
            Console.Write("Please enter your age >> ");

            // 3. Exceptions must be handled using "try/catch."
            try
            {
                int currentAge = Convert.ToInt32(Console.ReadLine());
                if (currentAge <= 0) 
                {
                    throw new AgeException("\nDo not enter zero or a negative age.");
                }

                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - currentAge;
            
                // 2. Display the year the user was born.
                Console.WriteLine("\nYou were born in " + yearBorn);
            }

            // 4. Display error message if the user enters zero or a negative age:
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            // 5. Display a general message if an exception was caused by anything else.
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine() ;
            }
        }
    }
}
