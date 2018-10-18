using NUnit.Framework;
using System.Threading.Tasks;

namespace xArchUnit.Tests.sampleTests
{
    [TestFixture]
    public class InterfaceRuleTests
    {
        [Test]
        public void interfaces_should_not_have_simple_class_names_ending_with_the_word_interface()
        {
            Check.NoClasses().That().AreInterfaces().Should().HaveSimpleNameContaining("Interface");

            Check.NoClasses().ResidesInAnAssembly("xy").That().AreInterfaces().Should().HaveSimpleNameContaining("Interface");
        }

        [Test]
        public void All_Interface_Methods_Should_Be_Async()
        {
            Check.Classes().That().AreInterfaces().Should().HaveMethods().That().Should().HaveNameEndingWith("Async").And().HaveReturnType(typeof(Task), typeof(Task<>));
        }
    }
}
