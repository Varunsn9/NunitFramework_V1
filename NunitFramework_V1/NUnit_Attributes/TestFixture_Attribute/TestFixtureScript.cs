using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.TestFixture_Attribute
{
    [TestFixture]
    [Category("TestFixture")]
    public class TestFixtureScript
    {
        [Test]
        public void TestFixtureForPublicClass()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
    [TestFixture]
    [Category("TestFixture")]
    public abstract class TestFixtureScriptAbstract
    {
        public string OTSU ;
        [OneTimeSetUp]
        public void TestFixtureForAbstractClassUtilizingOneTimeSetUp()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
            OTSU= "this is one time setup property";
        }
    }
    [TestFixture]
    [Category("TestFixture")]
    public class TestFixtureScriptAbstractUtilization : TestFixtureScriptAbstract
    {
        [Test]
        public void TestFixtureForPublicClassAbstractUtilization()
        {
            TestContext.WriteLine(OTSU);
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
    [TestFixture]
    [Category("TestFixture")]
    internal class TestFixtureScriptInternal
    {
        [Test]
        public void TestFixtureForInternalClass()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
    [TestFixture]
    [Category("TestFixture")]
    public static class TestFixtureScriptPublicStatic
    {
        [Test]
        public static void TestFixtureForPublicStaticClass()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
