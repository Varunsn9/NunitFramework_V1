using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.OneTimeTearDown_Attribute
{
    [TestFixture]
    [Category("OneTimeTearDown")]
    public class OneTimeTearDownScript
    {
        [OneTimeTearDown]//this method will be executed after a test
                      //if there are multiple test it will execute only once
                      //the output cannot be seen in testexplorer
                      // u can see the output of the onetimeTearDown in testreport.xml
                      //we should use onetimeTearDown in baseclass and should be inherited to the derived class for utilization
        public void OneTimeTearDownTest()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name}");
        }
        [Test]
        public void TestMethod()
        {
            Thread.Sleep(1000);
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
