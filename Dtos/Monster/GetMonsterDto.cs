using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Monster
{
    public class GetMonsterDto : Character, IAttack
    {
        public int Attak()
        {
            throw new NotImplementedException();
        }

        public int MagicAttak(string spell, out int MP)
        {
            throw new NotImplementedException();
        }

        int IAttack.Defence()
        {
            throw new NotImplementedException();
        }
    }
}
