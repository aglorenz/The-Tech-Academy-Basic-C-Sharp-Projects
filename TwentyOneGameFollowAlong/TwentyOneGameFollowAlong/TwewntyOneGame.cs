using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameFollowAlong
{
    public class TwentyOneGame : Game

    {   // In order to implement Play (an abstract method) in the inherited class, simply do the method the same way (public,void, Play()) 
        // but use override keyword. This satisfies the contract that we will define this method here. 
        public override void Play()  
        {
            throw new NotImplementedException();  // Put in a catch to show that the method has not been implemented yet.
        }

        public override void ListPlayers() // overriding ListPlayers implementation in the Class Game.  Customize by writing out a header
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
