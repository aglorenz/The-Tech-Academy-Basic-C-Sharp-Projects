using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number
            {
                Amount = 1.5m
            };
            Console.WriteLine("The amount is {0}", myNumber.Amount);
            Console.ReadLine();
        }
    }
}
