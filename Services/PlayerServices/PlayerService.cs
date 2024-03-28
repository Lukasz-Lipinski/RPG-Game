namespace myRPG.Services.PlayerServices
{
    public class PlayerService : SettingStats, IPlayerService
    {
        public Player GetPlayerById(Guid id) =>
            Store.Players.FirstOrDefault(p => Guid.Equals(p.Id, id));

        private readonly IMapper mapper;

        public PlayerService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void AddPlayerToDB(Player player)
        {
            Store.Players.Add(player);
        }

        public bool CheckIfPlayerExist(Guid id)
        {
            Player foundPlayer = this.GetPlayerById(id);

            if (Store.Players.Count != 0 && foundPlayer is null)
            {
                return false;
            }

            return true;
        }

        public Player CreatePlayer(CreatePlayer playerData)
        {
            var newPlayer = this.mapper.Map<Player>(playerData);
            newPlayer.Id = Guid.NewGuid();
            newPlayer.HP = (int)(
                this.GetHPOnStart(newPlayer.CharacterClass)
                + this.GetHPIndex(newPlayer.CharacterClass) * newPlayer.Level
            );
            newPlayer.MP = (int)(
                this.GetMPOnStart(newPlayer.CharacterClass)
                + this.GetMPIndex(newPlayer.CharacterClass) * newPlayer.Level
            );

            return newPlayer;
        }
    }
}
