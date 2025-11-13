using PokémonSimulator;

namespace PokémonSimulator
{
    internal sealed class Charizard : FirePokémon
    {
        public Charizard(int level, List<Attack> attacks) : base("Charizard", level, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: RAWR, CHARIZARD!");
        }
    }
}