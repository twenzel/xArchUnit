using System;
using System.Collections.Generic;
using System.Text;

namespace xArchUnit
{
    public interface IGivenObjects<T>
    {
        ArchRule Should(Condition<T> condition);

        IGivenConjunction<T> That(Func<T, bool> predicate);
    }
}
