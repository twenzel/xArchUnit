using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using xArchUnit;

namespace xArchUnit.Tests.sampleTests
{
    [TestFixture]
    public class InterfaceRuleTests
    {
        [Test]
        public void interfaces_should_not_have_simple_class_names_ending_with_the_word_interface()
        {
            RuleDefinitions.NoClasses().That().AreInterfaces().Should().HaveSimpleNameContaining("Interface");

            RuleDefinitions.NoClasses().ResidesInAnAssembly("xy").That().AreInterfaces().Should().HaveSimpleNameContaining("Interface");
        }
    }
}
