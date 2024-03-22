using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public interface IPlayerService
    {
        public void CheckIfPlayerExist(Player player, out bool result);
        public void AddPlayerToDB(Player player);
    }
}