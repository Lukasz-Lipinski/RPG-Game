using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public interface IPlayerService
    {
        public Character CreatePlayer(CreatePlayer playerData);
        public bool CheckIfPlayerExist(Guid id);
        public void AddPlayerToDB(Character player);
        public Character GetPlayerById(Guid id);
    }
}
