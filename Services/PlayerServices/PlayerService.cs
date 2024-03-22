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

        public void CheckIfPlayerExist(Player player, out bool result)
        {
            if (Store.Players.Count == 0)
            {
                result = false;
            }
            var foundPlayer = Store.Players
                .FirstOrDefault(p => p.Name == player.Name);

            if (foundPlayer is null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
        }
    }
}