using PokémonSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Charmeleon : FirePokémon, IEvolvable
    {
        public Charmeleon(int level, List<Attack> attacks) : base("Charmeleon", level, attacks)
        {
        }
        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Charizard!");
            Charizard charizard = new Charizard(Level, Attacks);
            return charizard;
        }
    }
}
