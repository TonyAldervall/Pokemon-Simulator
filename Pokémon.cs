namespace Pokémon_Simulator
{
    internal abstract class Pokémon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public ElementType Type { get; }
        public List<Attack> Attacks { get; }

        public Pokémon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks;
        }

        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan och anropar dess .Use-metod.
            Random rand = new Random();
            int index = rand.Next(Attacks.Count);
            Attacks[index].Use(Level);
        }
        public void Attack()
        {
            // Låter användaren välja en attack från listan och anropar dess .Use-metod.
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} (Type: {Attacks[i].Type}, Power: {Attacks[i].BasePower})");
            }
            Console.Write("Choose an attack by entering the corresponding number: ");
            int choice = int.Parse(Console.ReadLine() ?? "1") - 1;
            if (choice >= 0 && choice < Attacks.Count)
            {
                Attacks[choice].Use(Level);
            }
            else
            {
                Console.WriteLine("Invalid choice. Using default attack.");
                Attacks[0].Use(Level);
            }
        }
        public void RaiseLevel()
        {
            // Ökar nivån på Pokémon och skriver ut att den har levlat upp.
            Level++;
            Console.WriteLine($"{Name} has leveled up to level {Level}!");
        }
    }
}