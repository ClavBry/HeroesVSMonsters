using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Models
{
    public class Loup : Monstre , ICuir
    {
        private int _Cuir;
       
        public int Cuir
        {
            set { _Cuir = value; }
            get { return _Cuir; }
        }
        public Loup() : base()
        {
            this.Cuir = d.Lancer(4);
        }


    }
}
