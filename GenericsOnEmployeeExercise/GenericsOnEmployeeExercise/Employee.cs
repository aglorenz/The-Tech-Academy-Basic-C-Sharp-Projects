using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsOnEmployeeExercise
{
    // Make the Employee class take a generic parm
    public class Employee<T> : Person //, IQuittable
    {
        //public int Id { get; set; }

        // Add a property to the Employee class called "Things".  Have it's data type be a generic list
        //matching the generic type of the class.
        public List<T> Things { get; set; }


        // Overload operator == with this method.
        //public static Boolean operator ==(Employee firstEmployee, Employee secondEmployee)
        //{
        //    return firstEmployee.Id == secondEmployee.Id ? true : false;
        //}

        //// Overload operator != with this method.  It's required to be here because we have overloaded == above
        //public static Boolean operator !=(Employee firstEmployee, Employee secondEmployee)
        //{
        //    return firstEmployee.Id != secondEmployee.Id ? true : false;
        //}

        //public override void SayName() // override the SayName definition (declared in Person class) and implement it here.
        //{
        //    Console.WriteLine("Name: {0} {1}", firstName, lastName);
        //}

        //public void Quit() // implement the method from the IQuittable interface
        //{
        //    Console.WriteLine("\n\"I like turtles!\", said the polymorphic snowman.");
        //    Console.WriteLine("\nThen he said quite quickly, quirkily, and quietly, \"I quit.\"");
        //    Console.ReadLine();
        //}
    }
}
