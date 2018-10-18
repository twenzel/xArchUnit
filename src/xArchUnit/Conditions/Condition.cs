using System;

namespace xArchUnit.Conditions
{
    public abstract class Condition<T>
    {
        public string Description { get; }

        protected Condition(string description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public abstract void Check(T item);

        //public ArchCondition<T> And(ArchCondition<T> condition)
        //{
        //    return new AndCondition<T>(this, condition.< T > forSubType());
        //}

        //public ArchCondition<T> Or(ArchCondition<T> condition)
        //{
        //    return new OrCondition<>(this, condition.< T > forSubType());
        //}

        //public ArchCondition<U> ForSubType() where U:T
        //{
        //    return (ArchCondition<U>)this;
        //}
    }
}
