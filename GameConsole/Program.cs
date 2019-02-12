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