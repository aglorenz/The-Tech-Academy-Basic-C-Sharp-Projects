//
//  Author: Andrew Lorenz
//  Date:   12/05/2018
//  Purpose: Play with strings in C#
//           1) Concatenate 3 strings
//           2) Convert a string to uppercase
//           3) Use StringBuilder to build a paragraph of text, one sentence at a time:  The Three Bears of Forest Park

using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "The ";
            string myString2 = "cat ";
            string myString3 = "is furry!";
            string myFinalString = myString1 + myString2 + myString3;

            Console.WriteLine(myFinalString);

            Console.Write("\nEnter some text in lowercase\n>>");
            string uppperCaseString = (Console.ReadLine()).ToUpper();

            Console.WriteLine("\nYour string converted to upper case is: " + uppperCaseString);

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("\nOnce upon a time, there were three bears who lived in Forest Park.");
            paragraph.Append("\nThere was Mama Bear, Papa Bear and Little bear.");
            paragraph.Append("\nOne fine morning, they all went to Pittock Mansion to watch a beautiful sunrise.");
            paragraph.Append("\nAll that light made them hungry, but they didn't have any money for the food carts.");
            paragraph.Append("\nThey asked the photographers for money but they ran away in fear.");
            paragraph.Append("\nTo feed the family, Little Bear decided to become a software developer and enrolled at the Tech Academy.");
            paragraph.Append("\nHe graduated in record time and got a job in the IT department of a local bank.");
            paragraph.Append("\nThe Bears now have enough money to feed themselves and to help their extended family.");
            paragraph.Append("\nThey have even gained the trust and respect of the local photographers and pose for them regularly.");
            paragraph.Append("\n\n \t\t\t\t\tTHE END.");

            Console.WriteLine(paragraph);

            Console.ReadLine();

        }
    }
}
