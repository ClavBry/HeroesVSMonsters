using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Models
{
    public class Orque : Monstre , IOr
    {
        private int _Or;
     


        public int Or
        {
            set { _Or = value; }
            get { return _Or; }
        }

        public override int FOR { 
            get
            {
                return base.FOR + 1;
            }
        }
        public Orque() : base()
        {

            this.Or = d.Lancer(4);
        }
    }
}
