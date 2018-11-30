//
//  Author: Andrew Lorenz
//  Date:   11/29/2018
//  Purpose: Given business requirements, create program to demonstrate use of Boolean logic
//           Bus Req'ts:  Applicant for insurance  1) is older than 15, 2) no DUI's, 3) no more than 3 speeding tickets 

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("What is your age?\n>> ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("\nHave you ever had a DUI? (true or false)\n>>");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\nHow many speeding tickets do you have?\n>>");
            byte numTickets = Convert.ToByte(Console.ReadLine());

            // True if all 3 conditions are true:  1) is older than 15, 2) no DUI's, 3) no more than 3 speeding tickets 
            Console.WriteLine("\nQualified?\n>>" + ((age > 15) && (hadDUI == false) && (numTickets <= 3)));

            Console.ReadLine();


        }
    }
