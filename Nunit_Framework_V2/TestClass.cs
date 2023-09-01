using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NunitFramework_V1.TestIng_Concepts.FetchingDataFromResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Framework_V2
{
    [TestFixture]
    [Category("Listeners")]
    public class TestClass : BaseClass
    {

        [Test]
        public void Test([Values(1,2,3)] int b, [Values(1)]int a)
        {
            Assert.AreEqual(b, a);
        }
    }
}
