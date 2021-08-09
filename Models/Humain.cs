using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    class Humain : Hero
    {
        

        public override int FOR { get {return base.FOR+1; } }
        public override int End { get { return base.End+1;} }
  

    }

  
}
