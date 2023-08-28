using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.SetUp_Attribute
{
    [TestFixture]
    [Category("SetUp")]
    public class SetUpScript
    {
        [SetUp]
        // this method will execute before each tests inside a class
        // to utilize this in scripts it should be inherited from base class
        public void TestSetUpScript()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestSetUpScriptTestMethod()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestSetUpScriptTestMethod1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
        }
    }
}
