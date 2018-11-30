//
//  Author: Andrew Lorenz
//  Date:   11/29/2018
//  Purpose: Get hourly rate and hours worked per week of two people.  Calculate and output their annual income (assuming 52 weeks worked)
//           Output the boolean result of Person1 annual income > Person2 annual income

using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("\nAnonymous Income Comparison Program");

        // Person One
        Console.WriteLine("\nPerson 1");

        //get hourly rate
        Console.Write("Hourly Rate?\n>>");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

        //get hours worked per week
        Console.Write("Hours worked per week\n>>");
        int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Person Two
        Console.WriteLine("Person 2");

        //get hourly rate
        Console.Write("Hourly Rate?\n>>");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

        //get hours worked per week
        Console.Write("Hours worked per week\n>>");
        int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //Annual income Person 1
        double annualIncome1 = hourlyRate1 * hoursPerWeek1 * 52;
        Console.WriteLine("Annual income of Person 1:\n" + annualIncome1);

        //Annual income Person 2
        double annualIncome2 = hourlyRate2 * hoursPerWeek2 * 52;
        Console.WriteLine("Annual income of Person 2:\n" + annualIncome2);

        //Comparison
        Console.WriteLine("Does Person 1 make more then Person 2?\n" + (annualIncome1 > annualIncome2));

        Console.ReadLine();



    }
}
