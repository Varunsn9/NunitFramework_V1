using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Ignore_Attribute
{
    [TestFixture]
    [Ignore("ignoring the Fixture")]
    [Category("Ignore")]//using Ignore in the fixture
                        //nunit3-console "path of the dll" --where=category=Explicit
    public class IgnoreScript
    {
        [Test]
        public void Ignore_Attribute()
        {
            TestContext.WriteLine($"Utilizing Ignore Attribute in Fixture {TestContext.CurrentContext.Result.StackTrace}");
        }
        [Test]
        public void Ignore_Attribute1()
        {
            TestContext.WriteLine($"Utilizing Ignore Attribute in Fixture  {TestContext.CurrentContext.Result.StackTrace}");
        }
    }
    [TestFixture]
    [Category("Ignore")]
    public class IgnoreScript1
    {
        [Test]
        [Ignore("Ignoring the test")]//utilizing the ignoreAttribute to a test
        public void Ignore_Attribute()
        {
            TestContext.WriteLine($"Utilizing Ignore Attribute in Test {TestContext.CurrentContext.Result.StackTrace}");
        }
        [Test]
        [Ignore("Ignoring till the duration", Until = "2020-07-31 12:00:00Z")]
        public void Ignore_Attribute1()
        {
            TestContext.WriteLine($"not using Ignore Attribute in Test  {TestContext.CurrentContext.Result.StackTrace}");
        }
    }
}
    