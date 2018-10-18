using System;
using xArchUnit.Domains;

namespace xArchUnit
{
    public class GivenClasses : GivenObjects<Class>
    {
        public override IGivenConjunction<Class> And(Func<Class, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override IGivenConjunction<Class> Or(Func<Class, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override ArchRule Should(Condition<Class> condition)
        {
            throw new NotImplementedException();
        }

        public override IGivenConjunction<Class> That(Func<Class, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
