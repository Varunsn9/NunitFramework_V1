using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Timeout_Attribute
{
    [TestFixture]
    [Category("Timeout")]
    
    public class TimeoutScript
    {
        [Test]
        [Timeout(1000)]//milli seconds
        //timeout stops the execution and fails the test if the test havent executed completely

        public void Timeout_Attribute()
        {
            TestContext.WriteLine($"before failing the test script");
            Thread.Sleep(2000);
            TestContext.WriteLine("After failing the script");
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
