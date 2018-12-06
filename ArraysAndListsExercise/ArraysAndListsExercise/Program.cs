//
//  Author: Andrew Lorenz
//  Date:   12/06/2018
//  Purpose: Demonstrate array and list population and indexing
//           Bus Req'ts:  Create a array of strings, an array of integers, and a list of strings
//                        Ask user for an index to each and display the corresponding element.
//                        If user enters a number that is out of range, display an error and move to the next.
//           Assumption:  User may be confused by asking for a number between 0 and array size - 1.  So subtract 1 from the number they enter for 
//                        correct index to the array/list
using System;
using System.Collections.Generic;

namespace ArraysAndListsExercise
{
    class Program
    {
        static void Main()
        {
            // Array of Strings with 10 colors, one that contains spaces
            string[] colorArray = { "red", "blue", "orange", "purple", "yellow", "green", "brown", "black", "white", "burnt sienna" };
            int colorArrayLen = colorArray.Length;

            // Array of prime numbers.
            int[] numArray = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int numArrayLen = numArray.Length;

            // List of names
            List<string> nameList = new List<string> { "Shane", "Julie", "Mary", "Rose", "John", "Devin", "Stiofan", "Torin", "Aileen" };
            int nameListCount = nameList.Count;


            // Ask user for an color array index.  If index is out of range, display error, otherwise display the corresponding color
            Console.Write("\nTo get a color, enter a number between 1 and " + colorArrayLen + "\n>>");
            int colorIndex = Convert.ToInt32(Console.ReadLine());

            if ((colorIndex < 1) || (colorIndex > colorArrayLen))
            {
                Console.WriteLine("ERROR! You entered " + colorIndex + ". It must be between 1 and " + colorArrayLen);
            }
            else
            {
                Console.WriteLine("The color you selected is: " + colorArray[colorIndex-1]); // subtract 1 for correct index
            }

            // Ask user for a number array index.  If index is out of range, display error, otherwise display the corresponding number
            Console.Write("\nTo get a prime number, enter a number between 1 and " + numArrayLen + "\n>>");
            int numIndex = Convert.ToInt32(Console.ReadLine());

            if ((numIndex < 1) || (numIndex > colorArrayLen))
            {
                Console.WriteLine("ERROR! You entered " + numIndex + ". It must be between 1 and " + numArrayLen);
            }
            else
            {
                Console.WriteLine("The number you selected (from the array) is: " + numArray[numIndex - 1]); // subtract 1 for correct index
            }

            // Ask user for an index to the name list.  If index is out of range, display error, otherwise display the corresponding name
            Console.Write("\nTo get a person's name, enter a number between 1 and " + nameListCount + "\n>>");
            int nameIndex = Convert.ToInt32(Console.ReadLine());

            if ((nameIndex < 1) || (nameIndex > nameListCount))
            {
                Console.WriteLine("ERROR! You entered " + nameIndex + ". It must be between 1 and " + nameListCount);
            }
            else
            {
                Console.WriteLine("The name you selected is: " + nameList[nameIndex - 1]); // subtract 1 for correct index
            }

            Console.ReadLine();

        }
    }
}
