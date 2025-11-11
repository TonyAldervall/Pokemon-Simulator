using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3___Pokémon_Simulator
{
    internal class GrassPokémon : Pokémon
    {
        public GrassPokémon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Grass, attacks)
        {
        }
    }
}
