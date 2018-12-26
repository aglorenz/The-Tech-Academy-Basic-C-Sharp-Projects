//  Author: Andrew Lorenz
//  Date:   12/23/2018
//  Purpose:    Given requirements: Create a class called Person with two properties:  first and last name.  Give the class a 
//              void method SayName with no parms that writes the person's full name to the console  in format  Name:  [full name]
//              Create another class Employee and have it inherit from the Person class.  Give the Employee class a property Id of type int
//              In the main method, instantiate and initialize an Employee object with a first name of "Sample", last name "Student"
using System;

namespace InheritanceExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object
            Employee employee = new Employee  // showing simplified initialization
            {
                // Initialize the First and Last name in the superclass Employee
                FirstName = "Sample",
                LastName = "Student"
            };
            // Call the superclass method to print out the Employee first and last name
            employee.SayName();
            Console.ReadLine();
        }
    }
}
