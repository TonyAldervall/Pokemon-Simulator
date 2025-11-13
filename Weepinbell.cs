using PokémonSimulator;

namespace PokémonSimulator
{
    internal class Weepinbell : Pokémon, IEvolvable
    {
        public Weepinbell(int level, List<Attack> attacks) : base("Weepinbell", level, new List<ElementType> { ElementType.Grass, ElementType.Poison}, attacks)
        {
        }

        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Victreebel!");
            Victreebel victreebel = new Victreebel(Level, Attacks);
            return victreebel;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Weepinbell! Weepinbell!");
        }
    }
}