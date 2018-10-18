using NUnit.Framework;
using System.Threading.Tasks;

namespace xArchUnit.Tests.sampleTests
{
    [TestFixture]
    public class MethodRuleTests
    {
        [Test]
        public void Methods_Of_Classes_That_Returning_Task_Should_End_With_Async()
        {
            Check.Classes().That().HaveMethods().HaveReturnType(typeof(Task)).Should().HaveNameEndingWith("Async");
        }

        [Test]
        public void Methods_That_Returning_Task_Should_End_With_Async()
        {
            Check.Methods().That().HaveReturnType(typeof(Task)).Should().HaveNameEndingWith("Async");
        }
    }
}
