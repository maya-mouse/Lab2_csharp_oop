using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class TrainingGame : BaseGame
    {
        public override void basegame(GameAccount UserName, GameAccount OpponnentName, int raiting)
        {
            UserName.WinGame(OpponnentName, 3);
            OpponnentName.LoseGame(UserName, 3);
        }
    }
}
