using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public interface ISpecialDefense
    {
        int CalculateDamageReduction(int totalDamage);
    }
}
