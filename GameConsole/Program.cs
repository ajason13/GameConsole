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
            player.Name = "Conner";
            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}

// Nullable Value Types
// - Instance of System.Nullable<T> struct
// - Represent correct range of values plus additional null value
// - Wraps around value type