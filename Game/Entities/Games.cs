using System;
using System.Collections.Generic;
using System.Text;
using Game.entities;
using Game.Interfaces;

namespace Game.entities
{
    public class Games : IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GameRating { get; set; }
        public float GamePrize { get; set; }
    }
}
