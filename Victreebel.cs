using PokémonSimulator;

namespace PokémonSimulator
{
    internal class Victreebel : Pokémon
    {
        public Victreebel(int level, List<Attack> attacks) : base("Victreebel", level, new List<ElementType> { ElementType.Grass, ElementType.Poison }, attacks)
        {
        }
    }
}