namespace GameConsole
{
    public abstract class SpecialDefence
    {
        // change from interface IspecialDefence to an abstract class
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefence Null { get; } = new NullDefence();

        private class NullDefence : SpecialDefence //singleton
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // no operation / "do nothing" behavior
            }
        }
    }
}
