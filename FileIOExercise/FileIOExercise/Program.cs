/*
 * Author:  Andrew Lorenz
 * Date:    1/5/2019
 * Purpose: Demonstrate File I/O
 * Req'ts:  Ask the user for a number
 *          Log that number to a text file
 *          Print text file back to the user
 */
using System;
using System.IO;

namespace FileIOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number
            Console.Write("Enter your favorite number\n>> ");
            string stringNum = Console.ReadLine();

            // Log the number to a text file
            File.WriteAllText(@"C:\users\andy\logs\number.txt", stringNum);

            // Print the text file back to the user
            Console.Write("\nYour favorite number is ");
            Console.WriteLine(File.ReadAllText(@"C:\users\andy\logs\number.txt"));
            Console.ReadLine();

        }
    }
}
