//  Author: Andrew Lorenz
//  Date:   12/20/2018
//  Purpose:    Requirements: Create a class with a method that takes two integers as parameters
//              and make the second one optional.  Have the method do a math operation and return
//              an integer result.  Ask user for two numbers and tell them the 
//              second number is optional.  Display the result to the console.
// 
using System;

namespace ClassesAndMethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass myMath = new MathClass();

            // first number required
            Console.Write("\nEnter a number \n>> ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // second number is optional
            Console.Write("\nEnter a second number (optional)  Press Return to only use the first number \n>> ");
            string num2Str = Console.ReadLine();
            int mySum;
            
            // if the second number is omitted, then string will be ""
            // Display message showing sum with hidden number
            if (num2Str == "")
            {
                mySum = myMath.addition(num1);  // only one parameter passed
                Console.WriteLine("\n The sum of {0} and 50 is {1}", num1, mySum);
            }
            else
            {
                // Display message showing sum of two user numbers
                int num2 = Convert.ToInt32(num2Str);
                mySum = myMath.addition(num1,num2);  // two parameters passed
                Console.WriteLine("\nThe sum of {0} and {1} is {2}", num1, num2, mySum);
            }
            Console.ReadLine();
        }
    }
}
