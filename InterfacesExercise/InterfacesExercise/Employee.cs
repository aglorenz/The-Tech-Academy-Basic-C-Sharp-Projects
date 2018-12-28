using System;

namespace InterfacesExercise
{
    public class Employee : Person, IQuittable
    {
        public override void SayName() // override the SayName definition (declared in Person class) and implement it here.
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        public void Quit() // implement the method from the IQuittable interface
        {
            Console.WriteLine("\n\"I like turtles!\", said the polymorphic snowman.");
            Console.WriteLine("\nThen he said quite quickly, quirkily, and quietly, \"I quit.\"");
            Console.ReadLine();
        }
    }
}

