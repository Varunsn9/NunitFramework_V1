using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.TestOf_Attribute
{
    internal class TestOfScript
    {
    }
    [TestFixture]
    [Category("TestOfAttribute")]
    [TestOf(typeof(MyTests))]
    public class MyTests
    {
        [Test]
        public void Test1() { TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}"); }

        [Test]
        [TestOf(nameof(MyOtherTests))]
        public void Test2() { TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}"); }
    }

    [TestFixture(TestOf = typeof(MyOtherTests))]
    [Category("TestOfAttribute")]
    public class MyOtherTests
    {
        [Test]
        public void Test1() { TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}"); }

        [Test(TestOf = typeof(MyOtherTests))]
        public void Test2() { TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}"); }
    }
}
