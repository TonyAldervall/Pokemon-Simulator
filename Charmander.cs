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
        private int _evolveAtLevel = 16;
        public Charmander(List<Attack> attacks) : base("Charmander", 1, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Charmeleon!");
            Charmeleon charmeleon = new Charmeleon(Level, Attacks);
            return charmeleon;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Char! Char!");
        }
        public override Pokémon RaiseLevel()
        {
            base.RaiseLevel();
            if (Level >= _evolveAtLevel)
            {
                Pokémon evolved = Evolve();
                return evolved;
            }
            return this;
        }
    }
}
