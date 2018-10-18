using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace xArchUnit.Tests.sampleTests
{
    [TestFixture]
    public class ClassesTests
    {
        [Test]
        public void All_Classes_In_Manager_Assembly_Should_Have_Name_EndingWithManager()
        {
            Check.Classes().ResidesInAssembly("*.Manager").Should().HaveNameEnding("Manager");
            this.GetType().Assembly.Types().ThatAreUnderNamespace("as").Should().
        }

        public void Test1()
        {
            //Assembly.Classes().ResidesInAssembly("*.ManagerInterfaces")
            //    .Should().OnlyBeAccessed().ByClassesThat().ResidesInAssembly("*.Objects", "*.Managers");
        }
    }
}
