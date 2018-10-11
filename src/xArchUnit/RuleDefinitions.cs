using System;

namespace xArchUnit
{
    public static class RuleDefinitions
    {
        public static GivenClasses Classes()
        {
            return new GivenClasses();
        }

        public static GivenClasses NoClasses()
        {
            return new GivenClasses();
        }
    }
}
