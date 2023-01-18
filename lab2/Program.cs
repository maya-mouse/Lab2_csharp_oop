using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameAccount Player1 = new MinForfeitAccount("Моль");
            GameAccount Player2 = new BonusAccount("Мушка");
            GameAccount Player3 = new GameAccount("Мураха");
           
            int i = 0;
            while (i < 2)
            {
                Random rndm = new Random();
                int gamerating = rndm.Next(1,3);
                Minimization something = new Minimization();

                if (gamerating >=2)
                {
                   var session = something.TrainingGame();
                    session.basegame(Player2,Player3,gamerating);
                    var session1 = something.OneSideGame();
                    session1.basegame(Player1, Player2, gamerating);

                }
                else
                {

                    var session = something.TrainingGame();
                    session.basegame(Player1, Player3, gamerating);
                    var session1 = something.StandartGame();
                    session1.basegame(Player1, Player2, gamerating);
                }
                i++;
                Console.WriteLine("<<<<-------->>>>\n");
               Player1.GetStats();
    
                Console.WriteLine("\n<<<<-------->>>>\n");
               Player2.GetStats();
                Console.WriteLine("\n<<<<-------->>>>\n");
            
               Player3.GetStats();

            }
        }
    }
}
