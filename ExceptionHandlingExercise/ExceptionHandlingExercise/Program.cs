
//  Author: Andrew Lorenz
//  Date:   12/12/2018
//  Purpose: Given requirements, create program to demonstrate C Sharp exception handling 
//           Req'ts:    Create a list of integers and ask user for a number by which to divide each.       
//                      Divide each number in the list, catch errors and display appropriate error messages (ex: divide by 0, entering 
//                      non-numeric string
//                      
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // create a list of numbers
            List<int> intList = new List<int>() { 1, 30, 500, -500, 100000, 0, 8000 };
            Console.WriteLine("\nA list of numbers:\n");
            // and display the list
            foreach (int num in intList)
            {
                Console.WriteLine(num.ToString().PadLeft(6));
            }

            // query user for number by which to divide each number in the list
            Console.Write("\nPlease enter a number by which to divide the above numbers:\n>> ");
            int userNum = Convert.ToInt32( Console.ReadLine());

            // display the results
            Console.WriteLine("\nThe results are: \n");
            foreach (int num in intList)
            {
                Console.WriteLine(num.ToString().PadLeft(6) +  " divided by " + userNum + " = " + (num / userNum).ToString().PadLeft(6));
            }
        }

        // character strings not allowed
        catch (FormatException ex)
        {
            Console.WriteLine("\nError: Please enter a whole number! " + ex.Message);
        }

        // divide by zero not allowed
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("\nError:  Dividing by zero is not allowed! ");
        }

        //Continue with remainder of the program
        Console.WriteLine("\nExiting Try/Catch block...... continuing with the remainder of the program");
        Console.ReadLine();
    }
}
