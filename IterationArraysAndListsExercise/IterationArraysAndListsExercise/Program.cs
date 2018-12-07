//
//  Author: Andrew Lorenz
//  Date:   12/06/2018
//  Purpose: Various exercises.  Requirements are listed at the beginning of each exercise.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string 
        // in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.
        string[] names = { "Andy", "David", "Monroe", "Mary", "Katie", "Tina", "Roger" };

        Console.WriteLine("\nThe name list contains:\n");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.Write("\nEnter some text (it will be added to the end of each name in the list)\n>>");
        string addendum = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)
        {
            names[i] += " " + addendum;
        }

        // print out the names with the addendum
        Console.WriteLine();
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();

        // Create an infinite loop.
        //for (int k = 1; k > 0; k++)
        //{
        //    Console.WriteLine(k);
        //}

        // Fix the infinite loop so it will execute correctly
        for (int i = 1; i < 10; i++) // now there is a loop terminating condition i.e. when k reaches 10, the loop exits
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();

        //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator
        // This solution is the same as above AND meets the criteria
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        // Create a List of strings where each item in the list is unique. Ask the user to select text to search for in 
        // the List. Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        // Add code to the loop to tell the user if their input text is not in the list.
        // Add code to the loop that stops it from executing once a match has been found.
        List<string> states = new List<string>() { "Oregon", "Arizona", "Utah", "California", "Nevada", "Idaho", "Washington" };

        Console.WriteLine("\nA list of states:");
        foreach (string state in states)
        {
            Console.WriteLine(state);
        }

        Console.Write("\nEnter the nanme of a state\n>>");
        string myState = Console.ReadLine();

        int stateIndex = 0;  // use an index to track position in the list.   Couldn't find an attribute of the current list element that holds index
        bool stateFound = false;  // initialize flag to indicate if state was found in list

        foreach (string state in states)
        {

            if (state.Equals(myState))
            {
                Console.WriteLine("\nThe index of " + state + " is " + stateIndex);
                stateFound = true;
                break;
            }
            stateIndex++;
        }

        if (!stateFound)
        {
            Console.WriteLine("\n'" + myState + "' was not found in the list");
        }
        Console.ReadLine();

        //  Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in 
        // the List. Create a loop that iterates through the list and then displays the indices of the array that contain matching text 
        // on the screen. Add code to the loop that tells a user if they put in text that isn't in the list.
        List<string> cities = new List<string>() { "Portland", "Oregon City", "Gresham", "Aloha", "Portland", "Cannon Beach", "Tillamook" };

        Console.WriteLine("\nA list of cities:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Console.Write("\nEnter the nanme of an Oregon city\n>>");
        string myCity = Console.ReadLine();

        int cityIndex = 0;  // use an index to track position in the list.   Couldn't find an attribute of the current list element that holds index
        bool cityFound = false;  // initialize flag to indicate if city was found in list
        List<int> cityIndices = new List<int>();  // List to hold indices of cities found.

        foreach (string city in cities)
        {

            if (city.Equals(myCity))
            {
                cityIndices.Add(cityIndex);
                cityFound = true;
            }
            cityIndex++;
        }

        if (!cityFound)
        {
            Console.WriteLine("\n'" + myCity + "' was not found in the list");
        }
        else
        {
            // Display the list of indices found matching the entered text
            Console.Write("\nThe indices of " + myCity + " are: ");
            foreach (int index in cityIndices)
            {
                Console.Write(index + " ");
            }

        }


        Console.ReadLine();


        //Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the 
        //list, and displays a message showing the string and whether or not it has already appeared in the list.        

        List<string> colors = new List<string>() { "red", "orange", "yellow", "blue", "red", "purple", "green" };

        Console.WriteLine("\nA list of colors:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        int colorIndex = 0;  // use an index to track position in the list.   Couldn't find an attribute of the current list element that holds index

        Console.WriteLine();
        foreach (string color in colors)
        {
            // lookup first occurence of current color
            int firstColorIndex = colors.IndexOf(color);
            // if current color equals has already been seen before
            if (colorIndex > firstColorIndex)
            {
                // display message with color name and previous index
                Console.WriteLine("The color, " + (color+",").PadRight(10) + " has PREVIOUSLY     appeared in the list at index, " + firstColorIndex + ".");
            }
            else
            {
                // else display message with color name
                Console.WriteLine("The color, " + (color+",").PadRight(10) + " has NOT previously appeared in the list.");
            }
            colorIndex++;
        }


        Console.ReadLine();
    }
}
