using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3___Pokémon_Simulator
{
    internal class Bulbasaur : GrassPokémon, IEvolvable
    {
        public Bulbasaur(List<Attack> attacks) : base("Bulbasaur", 1, attacks)
        {
        }

        public void Evolve()
        {
            this.Name = "Ivysaur";
            this.Level += 10;
            Console.WriteLine($"Bulbasaur is evolving... Now it is a Ivysaur and its level is {this.Level}!");
        }
    }
}
