using AutoMapper;

namespace myRPG
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Player, GetPlayerDto>();
            CreateMap<Monster, GetMonsterDto>();
        }
    }
}
