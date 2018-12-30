/*
 * Author:  Andrew Lorenz
 * Date:    12/30/2018
 * Purpose: Demonstrate use of a structure
 * Req'ts:  Create a struct called Number and give iti the property "Amount" and have it be of data type decimal.
 *          In the Main() method, create an object of data type Number and assign an amount to it.
 *          Print this amount to the console.
 */using System;

namespace StructureExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number
            {
                Amount = 1.5m
            };
            Console.WriteLine("The amount is {0}", myNumber.Amount);
            Console.ReadLine();
        }
    }
}
