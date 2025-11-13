using PokémonSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Squirtle : WaterPokémon, IEvolvable
    {
        public Squirtle(List<Attack> attacks) : base("Squirtle", 1, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Wartortle!");
            Wartortle wartortle = new Wartortle(Level, Attacks);
            return wartortle;
        }
    }
}
