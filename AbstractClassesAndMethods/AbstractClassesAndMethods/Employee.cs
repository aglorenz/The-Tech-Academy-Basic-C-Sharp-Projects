using System;

namespace AbstractClassesAndMethods
{
    public class Employee : Person
    {
        public override void SayName() // override the SayName definition (declared in Person class) and implement it here.
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}

