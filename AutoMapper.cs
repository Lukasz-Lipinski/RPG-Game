namespace myRPG
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Character, GetPlayerDto>();
            CreateMap<CreatePlayer, Character>();

            CreateMap<Character, GetMonsterDto>();
        }
    }
}
