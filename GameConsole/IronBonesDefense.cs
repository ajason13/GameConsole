﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class IronBonesDefense : ISpecialDefense
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}