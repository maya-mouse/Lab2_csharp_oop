using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   public class Minimization
    {
        public BaseGame TrainingGame()
        {

            BaseGame TrainingGame = new TrainingGame();
            return TrainingGame;
        }
        public BaseGame OneSideGame()
        {

            BaseGame OneSideGame = new OneSideGame();
            return OneSideGame;
        }
        public BaseGame StandartGame()
        {

            BaseGame StandartGame = new StandartGame();
            return  StandartGame;
        }


    }
}
