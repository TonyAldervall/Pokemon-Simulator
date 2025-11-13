using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class GrassPokémon : Pokémon
    {
        public GrassPokémon(string name, int level, List<Attack> attacks) : base(name, level, new List<ElementType> { ElementType.Grass }, attacks)
        {
        }
    }
}
