using System;
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
            //Pillars of Object Oriented Programming  Inheritance,  polymorphism, abstraction, encapsulation

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Andy", "Bill", "Joe" };

            //// Calling the method in the class you're INHERITING from, you're are calling the superclass method.  
            //game.ListPlayers(); // Game in this instance is the superclass.
            //game.Play();
            //Console.ReadLine();

            //Game game = new Game();
            //game.Dealer = "Andy";
            //game.Name = "TwentyOne";

            //Card card = new Card { Face = "King", Suit = "Spades" }; 
            //card.Face = "King";
            //card.Suit = "Spades";

            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();  // Classic polymorphism.  One object TwentyOneGame, morphs into a higher order object. 
            //Game game = new TwentyOneGame();  // Classic polymorphism.  One object, TwentyOneGame, morphs into a higher order object, game. 
            //games.Add(game);
            //Game game = new Game();  // Can't instantiate now that Game is an abstract class 
            // a base class is AKA  parent or superclass class
            // a child class is AKA subclass or derived class

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Andy", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); // workaround to create empty list so we can add players to it.
            //Player player = new Player();
            //player.Name = "Andy";
            //game += player;
            //game -= player;

            // Enums limit the possible values you can receive from a user.  Great for drop down lists
            // Eliminates user entry error.
            // ConsoleColor color = ConsoleColor.Magenta;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;

            // enums have underlying data type of int assigned in order as as 1,2,3, etc 
            // (or you can assign them manually -- see Card())
            //int underlyingValue = (int)Suit.Diamonds;  //Casting a string to an integer instead of using Convert.ToInt32()
            //Console.WriteLine(underlyingValue);  // will write the value 10 (see Card() class)

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
