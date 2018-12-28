using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameFollowAlong
{
    public class Player
    {
        public List<Card> cards { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        // overloaded operator method to Add a player
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);  // remember, Players is a list and Add is a function that works on lists
            return game;
        }

        // overloaded operator method to Remove a player
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);  // Players is a list and Remove is a function that works on lists
            return game;
        }
    }
}
