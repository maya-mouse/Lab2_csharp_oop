using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class BonusAccount : GameAccount {
        public BonusAccount(string name) : base(name)
        {
        }
             public override Note WinGame(GameAccount opponentName, int rating)
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
            var Game = new Note(UserName,opponentName.UserName, 1, CurrentRating, 2 + rating, GamesCount);
            stats.Add(Game);
            return Game;

        }
       
    }

    }

