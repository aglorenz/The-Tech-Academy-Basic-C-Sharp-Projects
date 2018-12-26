using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise1
{
    public class Employee : Person // example of inheritance.  Employee INHERITS all properties and methods of Person
    {
        public int Id { get; set; } // Person class does not have access to Id
    }
}
