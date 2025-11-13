using PokémonSimulator;

namespace PokémonSimulator
{
    internal sealed class Victreebel : Pokémon
    {
        public Victreebel(int level, List<Attack> attacks) : base("Victreebel", level, new List<ElementType> { ElementType.Grass, ElementType.Poison }, attacks)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: REEE! REE!");
        }
    }
}