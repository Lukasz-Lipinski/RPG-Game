using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Monster
{
    public class GetMonsterDto : Monster, IGetCharacterTypeRaceClass
    {
        string IGetCharacterTypeRaceClass.CharacterClass
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        string IGetCharacterTypeRaceClass.CharacterRace
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        string IGetCharacterTypeRaceClass.CharacterType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
