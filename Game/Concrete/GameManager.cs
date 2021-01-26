using System;
using System.Collections.Generic;
using System.Text;
using Game.Concrete;
using Game.entities;
using Game.Interfaces;

namespace Game.Concrete
{
    public class GameManager : IGameServices
    {
        public void Add( Games game)
        {
            Console.WriteLine(game.GameName+ " Oyun Eklendi");
        }

        public void Delete(Games game)
        {
            Console.WriteLine(game.GameName + " Oyun Silindi");
        }

        public void GameCampaigne(Games game)
        {
            Console.WriteLine(game.GameName+ " Oyun Kampanyası Tanımlandı.");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GameName+ "Oyun Güncellendi."); 
        }
    }
}
