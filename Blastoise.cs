using PokémonSimulator;

namespace PokémonSimulator
{
    internal sealed class Blastoise : WaterPokémon
    {
        public Blastoise(int level, List<Attack> attacks) : base("Blastoise", level, attacks)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: BLASTOISE! BLASTOISE!");
        }
    }
}