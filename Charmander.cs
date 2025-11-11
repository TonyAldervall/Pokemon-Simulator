using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3___Pokémon_Simulator
{
    internal class Charmander : FirePokémon, IEvolvable
    {
        public Charmander(List<Attack> attacks) : base("Charmander", 1, attacks)
        {
        }

        public void Evolve()
        {
            this.Name = "Charmander";
            this.Level += 10;
            Console.WriteLine($"Charmander is evolving... Now it is a Charmeleon and its level is {this.Level}!");
        }
    }
}
