using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.OneTimeSetUp_Attribute
{
    [TestFixture]
    [Category("OneTimeSetUp")]
    public class OneTimeSetUpScript
    {
        [OneTimeSetUp]//this method will be executed before a test
                        //if there are multiple test it will execute only once
                        //the output cannot be seen in testexplorer
                        // u can see the output of the onetimesetup in testreport.xml
                        //we should use onetimesetup in baseclass and should be inherited to the derived c
        public void OneTimeSetUpTest()
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
