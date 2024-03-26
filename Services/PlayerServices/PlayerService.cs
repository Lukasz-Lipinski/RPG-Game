using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.PlayerServices
{
    public class PlayerService : IPlayerService
    {
        public void AddPlayerToDB(Player player)
        {
            Store.Players.Add(player);
        }

        public bool CheckIfPlayerExist(Player player)
        {

            Player foundPlayer;

            try
            {
                player = Store.Players
                    .FirstOrDefault(p => p.Name == player.Name);
                return false;
            }
            catch
            {
            }

            if (Store.Players.Count != 0 && player is null)
            {
                return false;
            }

            return true;
        }
    }
}