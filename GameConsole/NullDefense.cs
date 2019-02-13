namespace GameConsole
{
    class NullDefense : ISpecialDefense
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0;       // no operation/"do nothing" behavior
        }
    }
}
