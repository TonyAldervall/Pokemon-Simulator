using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Bellsprout : Pokémon, IEvolvable
    {
        public Bellsprout(List<Attack> attacks) : base("Bellsprout", 1, new List<ElementType> { ElementType.Grass, ElementType.Poison }, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Weepinbell!");
            Weepinbell weepinbell = new Weepinbell(Level, Attacks);
            return weepinbell;
        }
    }
}
