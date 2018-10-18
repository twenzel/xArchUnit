using System;

namespace xArchUnit
{
    public abstract class GivenObjects<T> : IGivenObjects<T>, IGivenConjunction<T>
    {
        public abstract IGivenConjunction<T> And(Func<T, bool> predicate);

        public abstract IGivenConjunction<T> Or(Func<T, bool> predicate);

        public abstract ArchRule Should(Condition<T> condition);

        public abstract IGivenConjunction<T> That(Func<T, bool> predicate);
    }
}
