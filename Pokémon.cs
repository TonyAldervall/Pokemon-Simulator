namespace PokémonSimulator
{
    internal abstract class Pokémon
    {
        private string _name;
        private int _level;
        public string Name
        {
            get 
            {
                return _name; 
            }
            set
            {
                if(value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Name has to contain 2-15 characters.");
                }
                _name = value;
            }
        }
        public int Level 
        {
            get
            {
                return _level;
            } 
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentException("Level has to be between 1-100.");
                }
                _level = value;
            }
        }
        public List<ElementType> Types { get; }
        public List<Attack> Attacks { get; set; }

        public Pokémon(string name, int level, List<ElementType> types, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Types = types;
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
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} (Type: {Attacks[i].Type}, Power: {Attacks[i].BasePower + Level})");
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
        public virtual Pokémon RaiseLevel()
        {
            // Ökar nivån på Pokémon och skriver ut att den har levlat upp.
            Level++;
            Console.WriteLine($"{Name} has leveled up to level {Level}!");
            return this;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} says: Rawr!");
        }

        public override string ToString()
        {
            return $"Pokémon: {Name}, Level: {Level}, Type(s): {string.Join(", ", Types)}, C# Class: {Name}";
        }
    }
}