using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     class MinForfeitAccount : GameAccount
    {
        public MinForfeitAccount(string name) : base(name)
        {

        }
        public override Note LoseGame(GameAccount opponentName, int rating)
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
            var Game = new Note(UserName,opponentName.UserName, 0,CurrentRating, -rating+2, GamesCount);
            stats.Add(Game);
            return Game;
        }

    }
}
