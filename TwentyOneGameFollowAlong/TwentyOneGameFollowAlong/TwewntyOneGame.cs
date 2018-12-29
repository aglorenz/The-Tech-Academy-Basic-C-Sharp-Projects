using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameFollowAlong
{
    // A class can inherit only one base class (Game).  But can inherit as many interfaces as necessary 
    public class TwentyOneGame : Game//, IWalkAway

    {   public override void Play()
        {
            throw new NotImplementedException();
        }
        // In order to implement Play (an abstract method) in the inherited class, simply do the method the same 
        // way (public,void, Play()) but use override keyword. This satisfies the contract that we will define 
        // this method here. 
        //public override void ListPlayers()  
        //{
        //    Console.WriteLine("21 Players:");
        //    base.ListPlayers();
        //    // Put in a catch to show that the method has not been implemented yet.
        //    //throw new NotImplementedException();  
        //}

        //public void WalkAway(Player player)
        //{
        //    throw new NotImplementedException();
        //}

        //// overriding ListPlayers implementation in the Class Game.  Customize by writing out a header
        //public override void ListPlayers() 
        //{
        //    Console.WriteLine("21 Players:");
        //    base.ListPlayers();
        //}
    }
}
