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
    public class SetUpFixtureSubTest
    {
        [Test]
        public void SetUpFixture()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
