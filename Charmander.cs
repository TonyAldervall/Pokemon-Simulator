using PokémonSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Charmander : FirePokémon, IEvolvable
    {
        public Charmander(List<Attack> attacks) : base("Charmander", 1, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Charmeleon!");
            Charmeleon charmeleon = new Charmeleon(this.Attacks);
            return charmeleon;
        }
    }
}
