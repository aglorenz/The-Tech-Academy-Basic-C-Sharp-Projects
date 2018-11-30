//
//  Author: Andrew Lorenz
//  Date:   11/29/2018
//  Purpose: To demonstrate what I've learned so far regarding C# variables and data types.   Mimic the Tech Academy Daily Report form.

using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report\n");

        Console.Write("What course are you on?\n>> ");
        string courseName = Console.ReadLine();

        Console.Write("\nWhat page number?\n>>");
        byte pageNumber = Convert.ToByte(Console.ReadLine());

        Console.Write("\nDo you need help with anything?  Please answer \"true\" or \"false\"\n>>");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        Console.Write("\nWere there any positive experiences you'd like to share?  Please give specifics.\n>>");
        string positiveExperiences = Console.ReadLine();

        Console.Write("\nIs there any other feedback you'd like to provide?  Please be specific.\n>>");
        string otherFeedback = Console.ReadLine();

        Console.Write("\nHow many hours did you study today?\n>>");
        byte hoursStudied = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("\nThank you for your answers.  An Instructor will respond to this shortly.  Have a great day!");



        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("             YOUR ANSWERS ");
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("Course Name: " + courseName + "\n");
        Console.WriteLine("Page number: " + pageNumber + "\n");
        Console.WriteLine("Needs help: " + needsHelp + "\n");
        Console.WriteLine("Positive Experiences: " + positiveExperiences + "\n");
        Console.WriteLine("Other Feedback: " + otherFeedback + "\n");
        Console.WriteLine("Hours Studied: " + hoursStudied );

        Console.Read();


    }
}
