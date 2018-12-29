using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameFollowAlong
{
    public abstract class Game // Game is a *base* class AKA an abstract class.  An abstract class can never be instantiated. 
                               // It can never be an object. It's only meant to be inherited from. We are never going to have an instance
                               // of game.
    {
        //public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();  // abstract methods can only exist in an abstract class.  Abstract method contains no implementation.
                                      // It almost looks like a property. Any class inheriting this class must implement this method.
                                      // it's sort of a contract between the base and the inheriting class.  

        // virtual means that this method get inherited by an inheriting class, but the inheriting class has the ability to override it.
        // virtual methods have implementation but they can be overridden.
        //public virtual void ListPlayers()  
        //{
        //    foreach (Player player in Players)
        //    {
        //        Console.WriteLine(player.Name);
        //    }
        //}



    }
}
