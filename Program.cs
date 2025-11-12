using System.Linq.Expressions;

namespace Pokémon_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);
            List<Attack> fireAttacks = new List<Attack>();
            fireAttacks.Add(flamethrower);
            fireAttacks.Add(ember);

            Attack watergun = new Attack("Water Gun", ElementType.Water, 10);
            Attack bubble = new Attack("Bubble", ElementType.Water, 5);
            List<Attack> waterAttacks = new List<Attack>();
            waterAttacks.Add(watergun);
            waterAttacks.Add(bubble);

            Attack vinewhip = new Attack("Vine Whip", ElementType.Grass, 11);
            Attack razorleaf = new Attack("Razor Leaf", ElementType.Grass, 7);
            List<Attack> grassAttacks = new List<Attack>();
            grassAttacks.Add(vinewhip);
            grassAttacks.Add(razorleaf);


            Charmander charmander = new Charmander(fireAttacks);
            Squirtle squirtle = new Squirtle(waterAttacks);
            Bulbasaur bulbasaur = new Bulbasaur(grassAttacks);

            List<Pokémon> pokémons = new List<Pokémon>();

            pokémons.Add(charmander);
            pokémons.Add(squirtle);
            pokémons.Add(bulbasaur);

            foreach (var pokémon in pokémons)
            {
                Console.WriteLine($"Pokémon: {pokémon.Name}, Level: {pokémon.Level}, Type: {pokémon.Type}");
                pokémon.Attack();
                pokémon.RandomAttack();
                pokémon.RaiseLevel();
                if (pokémon is IEvolvable evolvablePokémon)
                {
                    evolvablePokémon.Evolve();
                }
            }

            Console.ReadLine();
        }
    }
}
