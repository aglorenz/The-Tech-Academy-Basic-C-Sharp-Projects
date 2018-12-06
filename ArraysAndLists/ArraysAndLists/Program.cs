//
//  Author: Andrew Lorenz
//  Date:   12/05/2018
//  Purpose: Follow along exercise with Arrays and lists

using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

            List<string> strList = new List<string>();

            strList.Add("Hello");
            strList.Add("Andy");
            strList.Remove("Andy");

            Console.WriteLine(strList[0]);


            List<int> intList = new List<int>();

            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);


            Console.WriteLine(intList[0]); 


            Console.ReadLine();

            // Array Fundamentals
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;


            //// this way is easier to initialize
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //// This way you don't have to instantiate it.  it is done automatically
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();


        }
    }
}
