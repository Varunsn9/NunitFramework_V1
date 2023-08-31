using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.TestIng_Concepts.FetchingDataFromResult
{
    [TestFixture]
    [Category("Listeners")]
    public class TestScriptListeners 
    {
        [Test]
        public void TestingListeners()
        {
            TestContext.WriteLine($"the result is {TestContext.CurrentContext.Result}");
        }
        [Test]
        public void TestingListeners0()
        {
            TestContext.WriteLine($"the result is {TestContext.CurrentContext.Result}");
        }
        [Test]
        public void TestingListeners1()
        {
            TestContext.WriteLine($"the result is {TestContext.CurrentContext.Result}");
        }
    }
}
