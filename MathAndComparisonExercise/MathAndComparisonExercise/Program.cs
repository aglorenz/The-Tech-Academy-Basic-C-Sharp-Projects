//
//  Author: Andrew Lorenz
//  Date:   11/29/2018
//  Purpose: Demonstrate math and comparison operators in C#
using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number\n>> ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number times 50 = " + (inputOne * 50));

            Console.Write("\nEnter a number\n>> ");
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus 25 = " + (inputTwo + 25));

            Console.Write("\nEnter a number\n>> ");
            double inputThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 = " + (inputThree / 12.5));

            Console.Write("\nEnter a number\n>> ");
            int inputFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The statement: \"Your number is greater than 50\" is " + (inputFour > 50));

            Console.Write("\nEnter a number\n>> ");
            int inputFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The remainder of your number divided by 7 is " + (inputFive % 7));

            Console.ReadLine();

        }
    }
