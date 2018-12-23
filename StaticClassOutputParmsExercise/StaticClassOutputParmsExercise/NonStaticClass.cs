using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassOutputParmsExercise
{
    class NonStaticClass
    {
        // 1st of two overloaded methods - 3 parms
        public void ComputeQuotient(int dividend, out int quotient, out string outString)
        {
            quotient = dividend / 2;
            outString = "Happy Holidays!!!";
        }

        // 2nd of two overloaded methods - 1 parm
        public void ComputeQuotient(int dividend, out int quotient)
        {
            quotient = dividend / 2;
        }
    }
}
