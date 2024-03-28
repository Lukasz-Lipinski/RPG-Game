namespace myRPG.Services.PlayerServices
{
    public class PlayerService : IPlayerService
    {
        private readonly IMapper mapper;

        public PlayerService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void AddPlayerToDB(Player player)
        {
            Store.Players.Add(player);
        }

        public bool CheckIfPlayerExist(Player player)
        {
            Player foundPlayer = Store.Players.FirstOrDefault(p => p.Name == player.Name);

            if (Store.Players.Count != 0 && player is null)
            {
                return false;
            }

            return true;
        }

        public Player CreatePlayer(CreatePlayer playerData)
        {
            var newPlayer = this.mapper.Map<Player>(playerData);
            newPlayer.Id = new Guid();

            return newPlayer;
        }
    }
}
