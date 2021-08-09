using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.GUI;

namespace HeroesVSMonsters.Models
{
    public class Foret
    {
        //variable de champs privée
        //d'un de3 en lecture seule
        //d'un variable pour calculer le nombre de combat que le hero fait
        //d'un boolean pour voir voir si la partie est terminée
        //d'un hero en lecture seule
        //d'un monstre
        private readonly De _d;
        private int _nbrCombat;
        private bool _EndGame;
        private Hero _hero;
        private Monstre monster;

        public De de
        {
            get
            {
                return _d;
            }
        }

        public int NbrCombat
        {
            get
            {
                return _nbrCombat;
            }

            set
            {
                _nbrCombat = value;
            }
        }

        public bool EndGame
        {
            get
            {
                return _EndGame;
            }

            set
            {
                _EndGame = value;
            }
        }

        public Hero Hero
        {
            get
            {
                return _hero;
            }
        }

        public Monstre Monster
        {
            get
            {
                return monster;
            }

            set
            {
                monster = value;
            }
        }

        //les propriété qui vont avec le champs privé

        //le constructeur
        public Foret(Hero hero)
        {
            De d = new();
            this._hero = hero;
            Hero.Meurt += UnPersonnageEstMort;
            Console.WriteLine($"Un {Hero.GetType().Name} entre dans la frêt de Shorewood");
            Console.WriteLine($"Froce : {Hero.FOR}");
            Console.WriteLine($"End : {Hero.End}");
        }

     
        private void UnPersonnageEstMort(Personnage pers)
        {
            pers.Meurt -= UnPersonnageEstMort;

            if (pers is Hero)
            {
                EndGame = true;

                Console.WriteLine();
                Console.WriteLine("Le  héro est mort , pleurons le");
                Console.WriteLine($"Le héro a gagné {_nbrCombat}");
                Console.WriteLine($"Le héro à récolté {((Hero)pers).Or} pièces d'Or et {((Hero)pers).Cuir} morceaux de cuirs");
                
            }
            else
            {
                Console.WriteLine("Le monstre est mort");
                _nbrCombat++;
                Hero.Repos();
                Hero.Loot((Monstre)pers);
                Monster = getNextMonster();
            }
        }

        private Monstre getNextMonster()
        {
            Monstre monstre = null;

        
            De d = new();
            switch (d.Lancer(3))
            {
                case 1:
                    monstre = new Loup();
                    break;
                case 2:
                    monstre = new Orque();
                    break;
                case 3:
                    monstre = new Dragonnet();
                    break;
            }
            //todo delegate
            monstre.Meurt += UnPersonnageEstMort;

            Console.WriteLine();
            Console.WriteLine("Nous rencontrons un monstre");
            Console.WriteLine($"Type : {monstre.GetType().Name}");
            Console.WriteLine($"Force : {monstre.FOR}");
            Console.WriteLine($"End : {monstre.End}");

            return monstre;
        }


        //une méthode pour lancer la partie
        public void StartGame()
        {
            //je génére un Monstre
            Monster = getNextMonster();
            //je place un boolean qui dit que c'est le tour du joueur
            bool IsPlayerTurn = true;
            //je boucle tant que la partie n'est pas fini
            while (!EndGame)
            {
                //si c'estl e tour du joueur, il frappe monstre , si c'est tour du monstre il frappe le joueur
                //et j'inverse le boolean du tour du joueur
                if (IsPlayerTurn)
                {
                    Hero.Frappe(Monster);
                    IsPlayerTurn = false;
                }
                else
                {
                    Monster.Frappe(Hero);
                    IsPlayerTurn = true;
                }
            }
        }
    }
}

