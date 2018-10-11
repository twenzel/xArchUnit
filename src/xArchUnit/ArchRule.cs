using System.Collections.Generic;
using xArchUnit.Domains;

namespace xArchUnit
{
    public abstract class ArchRule
    {
        public abstract void Check(IEnumerable<Domain> domains);


        public abstract ArchRule Because(string reason);
    }
}
