namespace myRPG.Services.PlayerServices
{
    public class PlayerService : SettingStats, IPlayerService
    {
        public Character GetPlayerById(Guid id) =>
            Store.Players.FirstOrDefault(p => Guid.Equals(p.Id, id));

        private readonly IMapper mapper;

        public PlayerService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void AddPlayerToDB(Character player)
        {
            Store.Players.Add(player);
        }

        public bool CheckIfPlayerExist(Guid id)
        {
            Character foundPlayer = this.GetPlayerById(id);

            if (Store.Players.Count != 0 && foundPlayer is null)
            {
                return false;
            }

            return true;
        }

        public Character CreatePlayer(CreatePlayer playerData)
        {
            var newPlayer = this.mapper.Map<Character>(playerData);
            newPlayer.Id = Guid.NewGuid();
            Enum.TryParse<CharacterClass>(newPlayer.CharacterClass, out CharacterClass characterClass);

            newPlayer.HP = (int)(
                this.GetHPOnStart(characterClass)
                + this.GetHPIndex(characterClass) * newPlayer.Level
            );
            newPlayer.MP = (int)(
                this.GetMPOnStart(characterClass)
                + this.GetMPIndex(characterClass) * newPlayer.Level
            );

            return newPlayer;
        }
    }
}
