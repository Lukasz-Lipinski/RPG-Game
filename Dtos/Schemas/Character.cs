using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public abstract class Character
    {
        public string Name { get; set; }

        public abstract int Attack();
        public abstract int MagicAttack();
        public abstract void Defend();
    }
}
