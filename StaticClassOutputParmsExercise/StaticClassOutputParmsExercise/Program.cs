using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassOutputParmsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass myMath = new NonStaticClass();

            // Ask user for a number.
            Console.Write("\nEnter a number\n>> ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call 1st overloaded method in non-static class
            int quotient;
            Console.WriteLine("\n\nCalling first overloaded method in non-Static class...");
            myMath.ComputeQuotient(userNumber, out quotient);
            Console.WriteLine("\n{0} divided by 2 = {1}", userNumber, quotient);
            //
            // Call 2nd overloaded method in non-static class
            string message;
            Console.WriteLine("\n\nCalling second overloaded method in non-Static class...");
            myMath.ComputeQuotient(userNumber, out quotient, out message);
            Console.WriteLine("\n{0} divided by 2 = {1} \n{2}", userNumber, quotient, message);

            // Call method in static class
            Console.WriteLine("\n\nCalling method in Static class. Even though it has the same name, \n" 
                + "since it's in a separate class, this method is not overloaded...");
            Console.WriteLine("\n{0} divided by 2 = {1}", userNumber, StaticClass.ComputeQuotient(userNumber));
            Console.ReadLine();

        }
    }
}
