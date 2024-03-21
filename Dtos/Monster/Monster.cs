using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using myRPG.Dtos.Schemas;

namespace myRPG.Dtos.Monster
{
    public class Monster : Character
    {
        public Monster() { }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
