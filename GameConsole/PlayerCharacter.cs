using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        // Can be null since it's a class (reference type)
        public string Name { get; set; }

        // Can't be null since it's a struct (value type)
        //public int DaysSinceLastLogin { get; set; }
        //public Nullable<int> DaysSinceLastLogin { get; set; }

        // Instead of explicitly declaring Nullable<T>, can append '?' after type
        public int? DaysSinceLastLogin { get; set; }

        // Can't be null since it's a struct (value type)
        //public DateTime DateOfBirth { get; set; }
        //public Nullable<DateTime> DateOfBirth { get; set; }
        public DateTime? DateOfBirth { get; set; }

        // Default value is null. Don't need to set in constructor.
        public bool? IsNoob { get; set; }

        private readonly SpecialDefense _specialDefense;

        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
            
            /*
            DaysSinceLastLogin = -1;            // Magic Number
            DateOfBirth = DateTime.MinValue;    // Magic Number
            */
        }

        public PlayerCharacter(SpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }

        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if(_specialDefense != null)
            //{
            //damageReduction = _specialDefense.CalculateDamageReduction(damage);
            //}

            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
