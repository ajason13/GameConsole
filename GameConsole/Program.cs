using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            //player.Name = "Conner";
            //player.DaysSinceLastLogin = 42;
            //PlayerDisplayer.Write(player);

            //int days = player.DaysSinceLastLogin.Value;
            // ?. checks if player object is null AND DaysSinceLastLogin property is null
            int days = player?.DaysSinceLastLogin ?? -1;

            /*
            if(player != null)
            {
                days = player.DaysSinceLastLogin ?? -1;
            }
            else
            {
                days = -1;
            }
            */

            Console.WriteLine(days);

            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter{Name = "Sarah"},
                new PlayerCharacter(),
                null
            };

            // So player can be null and array value at index 0 can be null
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            //------------------------------------------------------------------

            // Null Reference Exceptions
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefense())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(new NullDefense())
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}

// Nullable Value Types
// - Instance of System.Nullable<T> struct
// - Represent correct range of values plus additional null value
// - Wraps around value type

// More on Nullable<T>
// - .HasValue  // false if null, true if valid value
// - .Value     // gets underlying value
// - .GetValueOrDefault() // underlying value or default
// - .GetValueOrDefault(default) // value or specified default

// Overview of Null-Checking Operators
// - Conditional Operator ?:
// - Null-Coalescing Operator ??
// - Null-Conditional Operator ?. ?[
//      - Good for when object itself is null
//      - Ex. int days = player.DaysSinceLastLoging ?? -1;  // But player can be null. So error anyway
//            int days = player?.DaysSinceLastLogin ?? -1;  // Also returns -1 if player is null.
//      - Good for arrays
//      - Good for Delegates
//          - Ex. PropertyChangedEventHandler eventHandler = PropertyChanged;
//                if(eventHandler != null)
//                {
//                      eventHandler(this, new PropertyChangedEventArgs(...));
//                }
//                ............. Upgrade to ..............
//                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(...));

// Null Object Pattern
// - Interface/Base class has a derived class of NULL which does nothing. Other classes can be instantiated.