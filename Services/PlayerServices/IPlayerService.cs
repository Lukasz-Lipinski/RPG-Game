using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public interface IPlayerService
    {
        public Player CreatePlayer(CreatePlayer playerData);
        public bool CheckIfPlayerExist(Guid id);
        public void AddPlayerToDB(Player player);
        public Player GetPlayerById(Guid id);
    }
}
