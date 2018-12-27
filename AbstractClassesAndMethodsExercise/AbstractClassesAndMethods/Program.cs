//  Author: Andrew Lorenz
//  Date:   12/27/2018
//  Purpose:    Requirements: Create a class called Person with two properties:  first and last name.  Give the class a 
//              method SayName() Create another class called Employee and have it inherit from the Person class.
//              implement the SayName() method inside of the Employee class.
//              Inside the Main() method, instantiate an Employee object with firsName "Sample" and lastName "Student".
//              Call the SayName() method on the object.
using System;

namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee // Instantiate Employee object and initialize first and last name.
            {
                firstName = "Sample",
                lastName = "Student"
            };

            employee.SayName();  // Write the name to the console.
            Console.ReadLine();

        }
    }
}
