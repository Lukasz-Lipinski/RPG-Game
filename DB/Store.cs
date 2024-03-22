using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.DB
{
    public static class Store
    {
        public static List<Player> Players { get; set; }
        public static List<Monster> Monsters { get; set; }
    }
}