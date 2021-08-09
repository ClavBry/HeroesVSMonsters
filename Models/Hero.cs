using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Models
{
    public abstract class Hero : Personnage, IOr, ICuir
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

        public void Repos()
        {
            ResetPv();
        }

        public void Loot(Monstre monstre)
        {
            if(monstre is IOr)
            {
                this.Or += ((IOr)monstre).Or;
            }
            if(monstre is ICuir)
            {
                Cuir += ((ICuir)monstre).Cuir;
            }
        }
    }
}
