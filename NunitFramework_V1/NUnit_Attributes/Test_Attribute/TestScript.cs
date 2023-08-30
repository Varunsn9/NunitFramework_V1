using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Test_Attribute
{
    [TestFixture]
    [Category("Test")]
    public class TestScript
    {
        [Test]
        // the test attribute is used to mark a method inside testfixture class declaring
        // -these are the test methods 
        public void TestMethod1() 
        {
            Console.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
