using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class WaterPokémon : Pokémon
    {
        public WaterPokémon(string name, int level, List<Attack> attacks) : base(name, level, new List<ElementType> { ElementType.Water }, attacks)
        {
        }
    }
}
