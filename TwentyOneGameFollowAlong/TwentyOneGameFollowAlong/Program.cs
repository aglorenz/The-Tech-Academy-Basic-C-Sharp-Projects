﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameFollowAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Andy", "Bill", "Joe" };

            //// Calling the method in the class you're inheriting from, you're are calling the superclass method.  
            //game.ListPlayers(); // Game in this instance is the superclass.
            //game.Play();
            //Console.ReadLine();

            //Game game = new Game();
            //game.Dealer = "Andy";
            //game.Name = "TwentyOne";

            //Card card = new Card { Face = "King", Suit = "Spades" }; 
            //card.Face = "King";
            //card.Suit = "Spades";


            Deck deck = new Deck();
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

    }
}
