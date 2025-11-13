using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonSimulator
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack attack) : base(attack.Name, attack.Type, attack.BasePower)
        {
        }

        public override void Use(int level)
        {
            Console.WriteLine($"Legendary Attack {Name} unleashed with a devastating power of {BasePower + level * 2}!");
        }
    }
}
