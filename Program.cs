using System.Linq.Expressions;

namespace PokémonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);
            Attack legendaryFlamethrower = new LegendaryAttack(flamethrower);

            List<Attack> fireAttacks = new List<Attack>();
            fireAttacks.Add(flamethrower);
            fireAttacks.Add(ember);
            fireAttacks.Add(legendaryFlamethrower);

            Attack watergun = new Attack("Water Gun", ElementType.Water, 10);
            Attack bubble = new Attack("Bubble", ElementType.Water, 5);
            Attack legendaryWatergun = new LegendaryAttack(watergun);
            List<Attack> waterAttacks = new List<Attack>();
            waterAttacks.Add(watergun);
            waterAttacks.Add(bubble);
            waterAttacks.Add(legendaryWatergun);

            Attack vinewhip = new Attack("Vine Whip", ElementType.Grass, 11);
            Attack razorleaf = new Attack("Razor Leaf", ElementType.Grass, 7);
            Attack legendaryVinewhip = new LegendaryAttack(vinewhip);
            List<Attack> grassAttacks = new List<Attack>();
            grassAttacks.Add(vinewhip);
            grassAttacks.Add(razorleaf);
            grassAttacks.Add(legendaryVinewhip);


            Pokémon charmander = new Charmander(fireAttacks);
            Pokémon squirtle = new Squirtle(waterAttacks);
            Pokémon bulbasaur = new Bulbasaur(grassAttacks);
            Pokémon bellsprout = new Bellsprout(grassAttacks);

            List<Pokémon> pokémons = new List<Pokémon>();

            pokémons.Add(charmander);
            //pokémons.Add(squirtle);
            //pokémons.Add(bulbasaur);
            //pokémons.Add(bellsprout);

            for(int i = 0; i < 40; i++)
            {
                RunThrough(pokémons);
            }


            Console.ReadLine();
        }

        private static void RunThrough(List<Pokémon> pokémons)
        {
            for (int i = 0; i < pokémons.Count; i++)
            {
                Console.WriteLine(pokémons[i].ToString());
                pokémons[i].Attack();
                pokémons[i].Speak();
                pokémons[i].RandomAttack();
                pokémons[i] = pokémons[i].RaiseLevel();
            }
        }
    }
}
