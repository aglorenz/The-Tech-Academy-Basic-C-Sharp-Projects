/*
 * Author:  Andrew Lorenz
 * Date:    1/5/2019
 * Purpose: Demonstrate constructor chaining, using var, and using const
 * Req'ts:  Create a const
 *          Create a variable using the keyword var
 *          Chain two constructors together (see Car class)
 */
using System;
using System.Collections.Generic;

namespace ConstructorChain_Const_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a const and print it to the console
            const string firstName = "Andy";
            Console.WriteLine("\nHi {0}, you are now a constant.\n", firstName);

            // create a variable using the keyword "var"
            var myList = new List<string>()
            {
                firstName,"is","a","constant."
            };

            // print out the contents of the list to the console
            foreach (string word in myList)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine();

            // instantiate a instance of a Car class using a chained constructor (there are 4 possible parameters)
            Car myCar = new Car("Andy", "Honda", "Civic");

            // output the car properties to the console
            Console.WriteLine("\n{0} owns a {1} {2}.", myCar.Owner, myCar.Make, myCar.Model);
            Console.WriteLine("This car has {0} cylinders.", myCar.NumCylinders);

            Console.ReadLine();
        }
    }
}
