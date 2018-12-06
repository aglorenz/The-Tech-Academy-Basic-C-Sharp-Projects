//
//  Author: Andrew Lorenz
//  Date:   12/05/2018
//  Purpose: Demonstrate a While loop and a Do While loop each using a boolean comparison.
//           I picked a simple and fun high/low game.  
//           While Loop - random number is generated between 1 and 10.  User must guess the number before loop exits.
//           Do While Loop = random number generated between 1 and 15.  User must guess the number before loop exits.

using System;

    class Program
    {
        static void Main()
        {
        Random rnd = new Random();
        Int32 randomNum = rnd.Next(1, 10); // Create a random number between 1 and 10

        Int32 guess = 0;    // initialize the while loop comparison var

        ///////////////////////////////////
        // Demonstrate a While Loop
        ///////////////////////////////////
        while (guess != randomNum)
        {
            Console.Write("Guess a number between 1 and 10 \n>>");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < randomNum)
            {
                Console.WriteLine("You guessed low.  Guess again.");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine("You guessed high.  Guess again.");
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
            }
        }
        ///////////////////////////////////
        // Demonstrate a Do While Loop
        ///////////////////////////////////

        Console.WriteLine("\nPlay 1 more time....");
        randomNum = rnd.Next(1, 15); // Create a random number between 1 and 15

        do
        {
            Console.Write("\nGuess a number between 1 and 15 \n>>");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < randomNum)
            {
                Console.WriteLine("You guessed low.  Guess again.");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine("You guessed high.  Guess again.");
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
            }
        }
        while (guess != randomNum);

        Console.ReadLine();

        }
    }
