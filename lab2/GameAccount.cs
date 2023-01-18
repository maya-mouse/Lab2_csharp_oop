using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
public class GameAccount
    {
     
         public string UserName { get; set; }
            public int GamesCount { get; set; }
            public int CurrentRating
            {
                get
                {
                    int currentRating = 11;
                    foreach (var item in stats)
                    {
                        currentRating += item.RatingGame;
                    }

                    return currentRating;
                }
            }
            public List<Note> stats = new List<Note>();
            public GameAccount(string name)
            {
                UserName = name;
                GamesCount = 0;

            }

            public virtual Note WinGame(GameAccount OpponentName, int rating)
            {
                if (rating >= CurrentRating)
                {
                    throw new ArgumentOutOfRangeException(nameof(rating), "Поточний рейтинг гравця має бути більший за рейтинг гри !");
                }
                if (rating <= 0)
               {
                   throw new ArgumentOutOfRangeException(nameof(rating), "Гра на мінусовий або рівний нулю рейтинг неможлива!");
                }
                this.GamesCount++;
                var Game = new Note(UserName,OpponentName.UserName, 1,CurrentRating, rating, GamesCount);
                stats.Add(Game);
            return Game;
        }
            public virtual Note LoseGame(GameAccount OpponentName, int rating)
            {
                if (rating >= CurrentRating)
                {
                    throw new ArgumentOutOfRangeException(nameof(rating), "Поточний рейтинг гравця має бути більший за рейтинг гри !");
                }
                if (rating <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rating), "Гра на мінусовий або рівний нулю рейтинг неможлива!");
                }

                this.GamesCount++;
                var Game = new Note(UserName, OpponentName.UserName,  0,CurrentRating, -rating, GamesCount);
                stats.Add(Game);
            return Game;
            }

        public void GetStats() 
            {

          int currentRating = 11;
           Console.WriteLine("History");
            foreach (var item in stats)
            {
             currentRating += item.RatingGame;
                Console.WriteLine("Гравець :\n" + UserName);
                Console.WriteLine("------------------------");
                Console.WriteLine("Ім'я опонента :\n" + item.Opponetname);
                Console.WriteLine("ID гри :\n" + item.ID);
            Console.WriteLine("Результат :\n" + item.Result);
            Console.WriteLine("Рейтинг гравця :\n" + currentRating);
                Console.WriteLine("Рейтинг гри:\n" + currentRating);
              

            }
           
                

        }
    
    }
  
}
 