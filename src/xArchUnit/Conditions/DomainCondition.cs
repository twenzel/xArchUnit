using System;
using System.Collections.Generic;
using System.Text;

namespace xArchUnit.Conditions
{
    public abstract class DomainCondition<T> : Condition<T> where T : Domains.Domain
    {
        protected DomainCondition(string description) : base(description)
        {
        }
    }
}
