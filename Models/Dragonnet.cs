using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Models
{
    class Dragonnet : Monstre , IOr, ICuir
    {
        
        
        private int _Or;
        private int _Cuir;
        

        public int Cuir
        {
            set { _Cuir = value; }
            get { return _Cuir; }
        }


        public int Or
        {
            set { _Or = value; }
            get { return _Or; }
        }



        public override int End { get { return base.End + 1; } }

        public Dragonnet() : base()
        {
            
            this.Cuir=base.d.Lancer(4);
            this.Or = d.Lancer(6);
           
        }
    }
}
