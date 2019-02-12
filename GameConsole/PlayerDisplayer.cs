using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            // IsNullOrWhiteSpace will also checks for empty strings "". Results = False.
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            // GetValueOrDefault is NULL checker
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            // Conditional Operator ?:
            //int? days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin : -1;

            // Null-Coalescing Operator ??
            // Either player.DaysSinceLastLogin or -1
            int days = player.DaysSinceLastLogin ?? -1;

            Console.WriteLine($"{days} since last login.");

            /*
            if(player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            
            // HasValue is NULL checker
            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin.Value);
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            */

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == false)
            {
                Console.WriteLine("Player is a newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
