using System;

class Program
{
    static void Main(string[] args)
    {
        try // divide two numbers entered by user.  first number / second number
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two....");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        // catch error if user enters a non-numeric string
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
            return;
        }
        // catch error if user enters 0 for second number
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        // general exceptions caught here
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // This section executed even if, for example, there is a return statement contained in other catches.
        finally
        {
            Console.ReadLine();
        }


    }
}
