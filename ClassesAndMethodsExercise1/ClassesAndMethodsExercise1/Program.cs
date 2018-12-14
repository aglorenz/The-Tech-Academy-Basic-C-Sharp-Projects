
//  Author: Andrew Lorenz
//  Date:   12/13/2018
//  Purpose:    Given requirements: Create a class with 3 methods each of which take 1 input parm and return
//              an integer.  Each method should do a simple math operation on the input. Put the class in a 
//              separate .cs file in the application.  Query the user from the console for an integer and 
//              call each method passing in the user input.  Display the result on the console.
//                      

using System;

namespace ClassesAndMethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number on which we will perform 3 mathmatic operations \n>> ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            // Call method to add 150 to user number and display to console
            Console.WriteLine("\n  " + userInt + " plus  150 = " 
                + Number.Add150To(userInt).ToString().PadLeft(5));

            // Call method to substract 22 from user number and display to console
            Console.WriteLine("\n  " + userInt + " minus  22 = " 
                + Number.Subtract22From(userInt).ToString().PadLeft(5));
            
            // Call method to multiplyuser number by 500 and display to console
            Console.WriteLine("\n  " + userInt + " times 500 = " 
                + Number.MultiplyBy500(userInt).ToString().PadLeft(5));

            Console.ReadLine();
        }
    }
}
