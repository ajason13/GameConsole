using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public abstract class SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        // Singleton pattern so only one instance of NullDefence is created and referenced
        public static SpecialDefense Null { get; } = new NullDefence();

        private class NullDefence : SpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0;
            }
        }
    }
}
