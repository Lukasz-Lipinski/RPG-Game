namespace myRPG
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Character, GetPlayerDto>();
            CreateMap<Character, AttackPlayerDto>();
            CreateMap<CreatePlayer, Character>();

            CreateMap<Character, GetMonsterDto>();
            CreateMap<Character, AttackMonsterDto>();
        }
    }
}
