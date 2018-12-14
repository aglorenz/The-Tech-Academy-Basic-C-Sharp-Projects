// My first class with 3 methods but no data types.
namespace ClassesAndMethodsExercise1
{
    public class Number
    {
        // Add 150 to input parameter and return sum
        public static int Add150To(int addend)
        {
            return addend + 150;
        }

        // subtract 22 from input parameter and return difference
        public static int Subtract22From(int minuend)
        {
            return minuend - 22;
        }

        // multiply input parameter by 500 and return product
        public static int MultiplyBy500(int factor)
        {
            return factor * 500;
        }

        // declaring this here means I don't have to do something like
        // Number myNum = new Number(); in the main program.  I love this!
        public Number()
        {
        }

    }
}
