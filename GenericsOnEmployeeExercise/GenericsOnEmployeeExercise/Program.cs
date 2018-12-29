/**************************************************************************************************************
Author: Andrew Lorenz
Date:   12/29/2018
Requirements:   Demonstrate use of generics.  Make the Employee class take a generictype parameter.  Add a 
                property to the Employee class called "Things" and have its data type be a generic list 
                matching the generic type of the class.  Instantiate an Employee object with type "string"
                as its generic parameter.  Assign a list of strings as the prooperty value of Things. Instantiate
                an Employee object with type "int" as its generic parameter. Assign a list of integers 
                as the property value of Things. Create a loop that prints lall of the Things to the Console
****************************************************************************************************************/
                  
using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericsOnEmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate an Employee object with type "string" as its generic parameter
            // Shorhand method to assign all properties of the object.  Compare with loop used above.
            Employee<string> employeeStrings = new Employee<string>
            {
                firstName = "Duran",
                lastName = "Duran",
                // Assign a list of strings as the property value of Things
                // Using the fast way to store the values.  Useful for small lists.
                Things = new List<string> { "Don't", "Save", "a", "Prayer", "for", "Me", "Now" }
            };

            // instantiate an Employee object with type "int" as its generic parameter
            Employee<int> employeeInts = new Employee<int>();

            employeeInts.firstName = "The";
            employeeInts.lastName = "Count";
            employeeInts.Things = new List<int>(); // Must instantiate the list before accessing it
            for (int i = 1; i <=5; i++) // Assign a list of integers as the property value of Things
            {
                employeeInts.Things.Add(i);
            }

            /* ---------------------------------------------------------------
                Create a loop that prints all of the Things to the Console
            ---------------------------------------------------------------- */
            
            // Print Integer list while having fun
            Console.WriteLine("\n{0} {1} loves to count...\n", employeeInts.firstName, employeeInts.lastName);
            for (int i = 0; i < employeeInts.Things.Count; i++)
            //foreach (int num in employeeInts.Things) <-- Alternate method to print out list
            {
                Console.Write("{0} ", employeeInts.Things[i]);
                for (int j = 1; j <= 5; j++)
                {
                    Thread.Sleep(120);
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n{0} Things!  Ah ah ahhhh.....!\n", employeeInts.Things[employeeInts.Things.Count-1]);
            Thread.Sleep(1500);
            
            // Print String list while having fun
            Console.WriteLine("\n{0} {1} sang the song:", employeeStrings.firstName, employeeStrings.lastName);
            Thread.Sleep(1000);
            foreach (string word in employeeStrings.Things)
            {
                Console.Write(word + " ");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
