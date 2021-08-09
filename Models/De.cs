using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    public class De
    {
        private int _maximum;
        private Random _rand;
        public const int _mini = 1;
        private static int Minimum { get { return _mini; } }

        public int Maximum
        {
            get
            {
                return _maximum;
            }
            private set
            {
                _maximum = value;
            }
        }
        

        public De()
        {
            _rand = new();
        }
      
        public int Lancer(int max)
        {
            return _rand.Next(max) + Minimum;
        }




    }
}
