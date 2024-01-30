using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_Demo
{
    // from https://james-ramsden.com/implement-ienumerable-c/

    // IEnumerable tells the compiler that there's something in the class we 
    // can iterate through
    public class IEnums : IEnumerable
    {
        public IEnums()   // Constructor
        {
            myData = new List<double>(new double[] { 3.4, 1.2, 6.2 });
        }
        private List<double> myData;



        // Here we implement the IEnumerable interface member
        // This is specific to this class object. This method gets called
        // when we try to iterate through this class with foreach.
        public IEnumerator<double> GetEnumerator()
        {
            foreach (double val in myData)
            {
                // Allows return of a value without breaking from the loop
                yield return val;
            }
        }

        //This method is also needed (to be compatible with the ICollection Interface), but usually you don't need to change it from this.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<double> GetReverseEnumerator()
        {
            for (int i = myData.Count - 1; i >= 0; i--)
            {
                yield return myData[i];
            }
        }
    }
}
