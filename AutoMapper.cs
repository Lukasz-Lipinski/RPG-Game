namespace myRPG
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Player, GetPlayerDto>();
            CreateMap<CreatePlayer, Player>();

            CreateMap<Monster, GetMonsterDto>();
        }
    }
}
