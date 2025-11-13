using PokémonSimulator;

namespace PokémonSimulator
{
    internal class Wartortle : WaterPokémon, IEvolvable
    {
        public Wartortle(List<Attack> attacks) : base("Wartortle", 16, attacks)
        {
        }
        public Pokémon Evolve()
        {
            Console.WriteLine($"{Name} is evolving... Now it is a Blastoise!");
            Blastoise blastoise = new Blastoise(this.Attacks);
            return blastoise;
        }
    }
}