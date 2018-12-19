using System;

namespace OverloadingExercise
{
     class Overload
    {
        
        public int MathOperation(int addend)
        {
            return addend + 150;
        }

        public int MathOperation(decimal factor)
        {
            return Convert.ToInt32( factor * 150);
        }

        public int MathOperation(string minuendStr)
        {
            int minuendInt = Convert.ToInt32(minuendStr);
            return minuendInt - 150;
        }
    }
}
