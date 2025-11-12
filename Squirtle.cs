using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Simulator
{
    internal class Squirtle : WaterPokémon, IEvolvable
    {
        public Squirtle(List<Attack> attacks) : base("Squirtle", 1, attacks)
        {
        }

        public void Evolve()
        {
            this.Name = "Wartortle";
            this.Level += 10;
            Console.WriteLine($"Squirtle is evolving... Now it is a Wartortle and its level is {this.Level}!");
        }
    }
}
