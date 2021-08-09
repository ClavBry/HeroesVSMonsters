using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Models
{
    class Nain : Hero , ICuir , IOr
    { 
        public override int End { get { return base.End + 2; } }
    }
}
