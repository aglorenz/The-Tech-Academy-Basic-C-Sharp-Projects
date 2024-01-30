using System;
using System.Collections.Generic;

namespace IEnumerable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnums myList = new IEnums();
            List<double> rtnList = new List<double>();
            
            // Iterate forward through list of IEnum objects
            foreach (var num in myList)
            {
                // need IEnumerable.GetEnumerator and
                // IEnumerator<double> to add double value to list
                rtnList.Add(num);
            }

            // Simple iteration through a list of doubles created by the above iteration (not objects)
            
            foreach (var num in rtnList)
            {
                Console.WriteLine(num);
            }

            // Iterate in reverse order through list of IEnum objects 
            foreach (var num in
                myList.GetReverseEnumerator())
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
