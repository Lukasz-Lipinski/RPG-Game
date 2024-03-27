using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public interface IPlayerService
    {
        public Player CreatePlayer(CreatePlayer playerData);
        public bool CheckIfPlayerExist(Player player);
        public void AddPlayerToDB(Player player);
    }
}
