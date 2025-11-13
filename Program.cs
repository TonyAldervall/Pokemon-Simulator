using System.Linq.Expressions;

namespace PokémonSimulator
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


            Pokémon charmander = new Charmander(fireAttacks);
            Pokémon squirtle = new Squirtle(waterAttacks);
            Pokémon bulbasaur = new Bulbasaur(grassAttacks);
            Pokémon bellsprout = new Bellsprout(grassAttacks);

            List<Pokémon> pokémons = new List<Pokémon>();

            pokémons.Add(charmander);
            pokémons.Add(squirtle);
            pokémons.Add(bulbasaur);
            pokémons.Add(bellsprout);

            for (int i = 0; i < pokémons.Count; i++)
            {
                Console.WriteLine(pokémons[i].ToString());
                pokémons[i].Attack();
                pokémons[i].RandomAttack();
                pokémons[i].RaiseLevel();
                if (pokémons[i] is IEvolvable evolvablePokémon)
                {
                    Pokémon evolved = evolvablePokémon.Evolve();
                    pokémons[i] = evolved;
                }
            }

            for (int i = 0; i < pokémons.Count; i++)
            {
                Console.WriteLine(pokémons[i].ToString());
                pokémons[i].Attack();
                pokémons[i].RandomAttack();
                pokémons[i].RaiseLevel();
                if (pokémons[i] is IEvolvable evolvablePokémon)
                {
                    Pokémon evolved = evolvablePokémon.Evolve();
                    pokémons[i] = evolved;
                }
            }

            for (int i = 0; i < pokémons.Count; i++)
            {
                Console.WriteLine(pokémons[i].ToString());
                pokémons[i].Attack();
                pokémons[i].RandomAttack();
                pokémons[i].RaiseLevel();
                if (pokémons[i] is IEvolvable evolvablePokémon)
                {
                    Pokémon evolved = evolvablePokémon.Evolve();
                    pokémons[i] = evolved;
                }
            }

            Console.ReadLine();
        }
    }
}
