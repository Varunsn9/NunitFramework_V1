using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.SetUpFixture_Attribute
{
    [TestFixture]
    [Category("SetUpFixture")]
    public class TestingSetUpFixture
    {
        [Test]
        public void TestMethod()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
