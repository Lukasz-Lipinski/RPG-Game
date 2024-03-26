using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace myRPG
{
    public class AutoMapper : Profile
    
        public AutoMapper()
        {
            CreateMap<Player, GetPlayerDto>();
            
        }
    }
}