using Xunit;

namespace myRPG.Tests
{
    public class PlayerServiceTests : IClassFixture<PlayerService>
    {
        private readonly IPlayerService playerService;
        private Player First_MockPlayer =
            new()
            {
                HP = 100,
                MP = 100,
                Level = 1,
                Name = "First Player",
                CharacterType = CharacterType.Alive,
                CharacterClass = CharacterClass.Mag,
                CharacterRace = CharacterRace.Human
            };

        private Player Second_MockPlayer =
            new()
            {
                HP = 100,
                MP = 100,
                Level = 1,
                Name = "Second Player",
                CharacterType = CharacterType.Alive,
                CharacterClass = CharacterClass.Warrior,
                CharacterRace = CharacterRace.Human
            };

        [Fact]
        public void CheckIfPlayerExistReturnsTrue()
        {
            Store.Players.Add(this.First_MockPlayer);
            Assert.True(this.playerService.CheckIfPlayerExist(this.First_MockPlayer));
        }

        [Fact]
        public void CheckIfPlayerExistReturnsFalse()
        {
            Store.Players.Add(this.First_MockPlayer);
            Assert.False(this.playerService.CheckIfPlayerExist(this.Second_MockPlayer));
        }
    }
}
