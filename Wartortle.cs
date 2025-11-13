using PokémonSimulator;

namespace PokémonSimulator
{
    internal class Wartortle : WaterPokémon, IEvolvable
    {
        public Wartortle(int level, List<Attack> attacks) : base("Wartortle", level, attacks)
        {
        }
        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Blastoise!");
            Blastoise blastoise = new Blastoise(Level, Attacks);
            return blastoise;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Wartortle! Wartortle!");
        }
    }
}