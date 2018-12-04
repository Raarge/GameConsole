using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

       
        public string Name { get; set; }

        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if (_specialDefence != null)
            //{
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}
            

            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
        public int? DaysSinceLastLogin { get; set; }  //short hand int?  instead of Nullable<int>
        public DateTime? DateOfBirth { get; set; }  // same as above

        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;

            // Using Magic Numbers Not the Preferred Way to Do this
            //DateOfBirth = DateTime.MinValue;  //magic number
            //DaysSinceLastLogin = -1; // magic number
        }
    }
}
