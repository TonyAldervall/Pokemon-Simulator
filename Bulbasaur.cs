using PokémonSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Bulbasaur : GrassPokémon, IEvolvable
    {
        public Bulbasaur(List<Attack> attacks) : base("Bulbasaur", 1, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Ivysaur!");
            Ivysaur ivysaur = new Ivysaur(Level, Attacks);
            return ivysaur;
        }
    }
}
