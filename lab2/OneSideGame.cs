using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   public class OneSideGame : BaseGame
    {
        public override void basegame(GameAccount UserName, GameAccount OpponentName, int rating)
        {
            UserName.WinGame(OpponentName, rating);
            OpponentName.LoseGame(UserName, 3);
        }
    }
}
