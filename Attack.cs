using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class Attack
    {
        public string Name { get; }
        public ElementType Type { get; }
        public int BasePower { get; }
        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public virtual void Use(int level)
        {
            Console.WriteLine($"{Name} hit with a total power of {BasePower + level}!");
        }
    }
}
