//  Author: Andrew Lorenz
//  Date:   12/27/2018
//  Purpose:    Requirements: Create an interface called IQuittable andhave it define a void method called Quit
//              Have your Employee class from the previous drill inherit that interface and implement the Quit()
//              method in any way you choose.  Use polymorphism to create an object of type IQuittable and call the 
//              Quit() method on it.
using System;

namespace InterfacesExercise
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

            IQuittable iquit = new Employee();  // <== polymorphism right here, folks!
            iquit.Quit();

            //employee.SayName();  // Write the name to the console.
            //Console.ReadLine();

        }
    }
}
