using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public interface IAttack
    {
        public int Attak();
        public int Defence();
        public int MagicAttak(string spell, out int MP);
    }
}