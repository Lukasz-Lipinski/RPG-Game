using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public interface IPlayerService
    {
        public bool CheckIfPlayerExist(Player player);
        public void AddPlayerToDB(Player player);
    }
}