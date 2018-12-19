//  Author: Andrew Lorenz
//  Date:   12/19/2018
//  Purpose:    Given requirements: Create a class with 3 methods of the same name.  Each will take 1 input parm of 
//              int, decimal respectively and return an integer. 
//              Each method should do a simple math operation on the input.   Display the result on the console.
using System;

namespace OverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My method overload demo\n");

            // instantiate the class and pass an int to the first method
            Overload myNum1 = new Overload();
            int number1 = 12;

            int result = myNum1.MathOperation(number1);
            Console.WriteLine("{0} + 150 = {1}\n", number1, result);

            // instantiate the class and pass a decimal to the second method (same name)
            Overload myNum2 = new Overload();
            decimal number2 = 32.3m;

            result = myNum2.MathOperation(number2);
            Console.WriteLine("{0} * 150 = {1}\n", number2, result);

            // instantiate the class and pass a string to the third method (same name)
            Overload myNum3 = new Overload();
            string number3Str = "45";

            result = myNum3.MathOperation(number3Str);
            Console.WriteLine("{0} - 150 = {1}", number3Str, result);

            Console.ReadLine();
        }
    }
}
