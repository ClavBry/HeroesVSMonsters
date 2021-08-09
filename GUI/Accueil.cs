using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonsters.Models;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.GUI
{
    public class Accueil
    {
        public void AfficherMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@" ___ ___                                                    ");
            Console.WriteLine(@" /   |   \   ___________  ____   ____   ______               ");
            Console.WriteLine(@"/    ~    \_/ __ \_  __ \/  _ \_/ __ \ /  ___/               ");
            Console.WriteLine(@"\    Y    /\  ___/|  | \(  <_> )  ___/ \___ \                ");
            Console.WriteLine(@"\___ |_  /  \___  >__|   \____/ \___  >____  >               ");
            Console.WriteLine(@"       \/       \/                  \/     \/                ");
            Console.WriteLine(@"           ____   _____________                              ");
            Console.WriteLine(@"           \   \ /   /   _____/                                         ");
            Console.WriteLine(@"            \   Y   /\_____  \                                        ");
            Console.WriteLine(@"             \      / /        \                                  ");
            Console.WriteLine(@"              \___ / /_______  /                              ");
            Console.WriteLine(@"                             \/                         ");
            Console.WriteLine(@"    _____                          __  ");
            Console.WriteLine(@"   /     \   ____   ____   _______/  |_  ___________  ______  ");
            Console.WriteLine(@"  /  \ /  \ /  _ \ /    \ /  ___/\   __\/ __ \_  __ \/  ___/  ");
            Console.WriteLine(@" /    Y    (  <_> )   |  \\___ \  |  | \  ___/|  | \/\___ \   ");
            Console.WriteLine(@" \____ |__  /\____/|___|  /____  >|__|  \___  >__|  /____  >  ");
            Console.WriteLine(@"          \/            \/     \/            \/           \/  ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n \n \n           Appuie enter pour jouer / Esc pour quitter \n \n \n  ");


            ConsoleKey k = Console.ReadKey(true).Key;
            if (k == ConsoleKey.Enter)
            {
                choisirHero();

            }
            if (k == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.Write("A bientôt");
                Environment.Exit(0);
            }
         

        }

        public void Rejouer()
        {
            AfficherMenu();
        }

        public void choisirHero()
        {
            Console.WriteLine("Choisissez votre héro : \n 1- Hero  \n 2- Nain ");
            ConsoleKeyInfo key = Console.ReadKey();

            if (char.IsDigit(key.KeyChar))
            {
                int val = int.Parse(key.KeyChar.ToString());
                if (val == 1)
                {
                    Humain h = new Humain();
                    Foret foret = new Foret(h);
                    foret.StartGame();
                }
                if (val == 2)
                {
                    Nain n = new Nain();
                    Foret foret = new Foret(n);
                    foret.StartGame();
                }
                else
                {
                    ConsoleKey k = new();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nVoulez vous rejouer Enter? / Escape pour quitter ");
                    k = Console.ReadKey(true).Key;
                    if (k == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        AfficherMenu();
                    }
                    else if (k == ConsoleKey.Escape) Environment.Exit(0);
                }


            }

        }
    }
}

