using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace HeroesVSMonsters.Models
{
    public abstract class Personnage
    {
        public event Action<Personnage> Meurt; 

        private int _End;
        private int _For;
        private int _PV;
        public readonly De d = new();
        private int[] _lanceStat = new int[4];
    
        public Personnage()
        {
            this._End = AttribuerStat();
            this._For = AttribuerStat();
            ResetPv(); 
        }
        public virtual int End
        {
            get { return _End; }
            private set { _End = value; }
        }
        public virtual int FOR
        {
            get { return _For; }
            private set { _For = value; }
        }
        private int PV
        {
            get { return _PV; }
            set 
            { 
                _PV = value; 
                if(_PV <= 0 && Meurt != null)
                {
                    Meurt(this);
                }

            }
        }


        public void Frappe(Personnage cible)
        {
            int Dmg = d.Lancer(4) + GetModificateur(FOR);
            
            Console.WriteLine($"inflige {Dmg} point de dégat");
            cible.PV -= Dmg;
        }

        public int AttribuerStat()
        {

            for (int i = 0; i <= 3; i++)
            {
                _lanceStat[i] = d.Lancer(6);
            }
            Array.Sort(_lanceStat);
            Array.Reverse(_lanceStat);

            for (int i = 0; i < 3; i++)
            {
                _lanceStat[3] += _lanceStat[i];
            }
           
            return _lanceStat[3];


        }

        private int GetModificateur (int carateristique)
        {
            int modif;
            switch (carateristique)
            {
                case < 5:
                    modif = -1;
                    break;
                case < 10:
                    modif = 0;
                    break;
                case < 15:
                    modif = 1;
                    break;
                default:
                    modif = 2;
                    break;
            }
            return modif = 0;
        }

        protected void ResetPv()
        {
            PV = End + GetModificateur(End);
        }
    }
}
