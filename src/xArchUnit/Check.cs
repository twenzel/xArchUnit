using xArchUnit.Conditions;

namespace xArchUnit
{
    /// <summary>
    /// This is the starting point for all checks
    /// </summary>
    public static class Check
    {
        //public static GivenClasses Classes()
        //{
        //    return new GivenClasses();
        //}

        //public static GivenClasses NoClasses()
        //{
        //    return new GivenClasses();
        //}

        public static ClassCondition Classes()
        {
            return new ClassCondition();
        }

        public static ClassCondition NoClasses()
        {
            return new ClassCondition().Negate();
        }
    }
}
