using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     public abstract class BaseGame

    {
        GameAccount UserName;
        GameAccount OpponetName;
        public int Rating;


        public abstract void basegame(GameAccount UserName, GameAccount OpponnentName, int rating);
      
          

    }
}
