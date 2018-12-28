//  Author: Andrew Lorenz
//  Date:   12/28/2018
//  Purpose:    Requirements: Using previous Employee/Person exercise, overload the "==" operatore so it checks
//              if two Employee objects are equal by comparing their Id property.
using System;

namespace OperatorOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee // Instantiate Employee object and initialize first and last name.
            {
                firstName = "Andy",
                lastName = "Lorenz",
                Id = 1
            };
            
            // Here we have two employees with the same name but different Id 
            Employee employee2 = new Employee
            {
                firstName = "Andy",
                lastName = "Lorenz",
                Id = 2
            };

            Console.WriteLine("\nSince \n\n\tEmployee 1 Id = {0}, and \n\tEmployee 2 Id = {1},", employee1.Id, employee2.Id);

            if (employee1 == employee2)
            {
                Console.WriteLine("\nthe employees are the same person.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nthe employees are NOT the same person.");
                Console.ReadLine();
            }

            IQuittable iquit = new Employee();  // <== polymorphism right here, folks!
            iquit.Quit();

            //employee.SayName();  // Write the name to the console.
            //Console.ReadLine();

        }
    }
}
