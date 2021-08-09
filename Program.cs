using System;
using HeroesVSMonsters.Models;
using HeroesVSMonsters.Interfaces;
using HeroesVSMonsters.GUI;

namespace HeroesVSMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Accueil accueil = new();
            accueil.AfficherMenu();
          
        }
    }
}
