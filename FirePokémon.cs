using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class FirePokémon : Pokémon
    {
        public FirePokémon(string name, int level, List<Attack> attacks) : base(name, level, new List<ElementType> { ElementType.Fire }, attacks)
        {
        }
    }
}
