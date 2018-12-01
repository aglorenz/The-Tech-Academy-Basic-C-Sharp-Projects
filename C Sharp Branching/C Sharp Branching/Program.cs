//
//  Author: Andrew Lorenz
//  Date:   11/30/2018
//  Purpose: Given business requirements, create program to demonstrate C Sharp branching and formatting output in currency 
//           Bus Req'ts:   Package Express shipping. If weight > 50, exit with error. Sum the package dimensions.  If sum is
//                          > 50 exit with error message.  Shipping quote is sum of dimensions * weight / 100
//                          output quote in money format  e.g., $4.40

using System;

class Program
{
    static void Main()
    {
        // Welsome
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below. ");

        // Prompt for Weight
        Console.Write("\nWhat is the package weight?\n>> ");
        float pkgWeight = float.Parse(Console.ReadLine());
        
        //If weight is greater than 50, then print message and exit
        if (pkgWeight > 50)
        {
            Console.WriteLine("\nPackage too heavy to be shipped via Package Express.  Have a good day!");
        }
        else {  // package not too heavy, then proceed

            // Get package width
            Console.Write("\nWhat is the package width?\n>> ");
            float pkgWidth = float.Parse(Console.ReadLine());

            // Get package height
            Console.Write("\nWhat is the package height?\n>> ");
            float pkgHeight = float.Parse(Console.ReadLine());

            // Get package length
            Console.Write("\nWhat is the package lenghth\n>> ");
            float pkgLength = float.Parse(Console.ReadLine());

            float sumDimensions = pkgLength + pkgWidth + pkgHeight;
            // If package too big, then print message and exit
            if (sumDimensions > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express");
            }
            else
            {
                // formatted with the Currency ("C") Format Specifier see
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#the-currency-c-format-specifier                Console.WriteLine("\nYour estimated total for shipping this package is: " + (sumDimensions * pkgWeight / 100).ToString("C2"));
            }

        };

        Console.ReadLine();


    }
}
