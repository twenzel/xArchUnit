using System;
using System.Collections.Generic;
using System.Text;

namespace xArchUnit
{
    public interface IGivenObjects<T>
    {
        ArchRule Should(ArchCondition<T> condition);

        IGivenConjunction<T> That(Func<T, bool> predicate);
    }
}
