using PokémonSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Ivysaur : GrassPokémon, IEvolvable
    {
        public Ivysaur(int level, List<Attack> attacks) : base("Ivysaur", level, attacks)
        {
        }
        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Venusaur!");
            return new Venusaur(this.Level, this.Attacks);
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Ivysaur! Ivysaur!");
        }
    }
}
