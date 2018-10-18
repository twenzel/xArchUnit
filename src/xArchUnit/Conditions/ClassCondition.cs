using xArchUnit.Domains;

namespace xArchUnit.Conditions
{
    public class ClassCondition : DomainCondition<Class>
    {
        public ClassCondition() : base("Classes")
        {
        }

        public override void Check(Class item)
        {
            throw new System.NotImplementedException();
        }
    }
}
