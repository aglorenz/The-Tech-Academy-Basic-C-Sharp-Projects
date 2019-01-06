using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain_Const_Var
{
    public class Car
    {
        public Car(string owner, string make, string model) : this(owner, make, model, 4)
        {
        }

        public Car (string owner, string make, string model, int numCylinders)
        {
            Owner = owner;
            Make = make;
            Model = model;
            NumCylinders = numCylinders;
        }

        public string Owner { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumCylinders { get; set; }
    }
}
