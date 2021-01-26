using System;
using System.Collections.Generic;
using System.Text;
using Game.Interfaces;
using Game.entities;

namespace Game.Interfaces
{
    public interface IGameServices
    {
        void Add(Games game);

        void GameCampaigne(Games game);

        void Delete(Games game);

        void Update(Games game);

    }
}
