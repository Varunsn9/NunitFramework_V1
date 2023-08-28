using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly: RequiresThread]
//The RequiresThreadAttribute is used to indicate that a test method,
//class or assembly should be run on a separate thread
namespace NunitFramework_V1.NUnit_Attributes.RequiresThread_Attribute
{
    [TestFixture,RequiresThread]
    [Category("RequiresThread")]
    public class RequiresThreadScript
    {
        [Test, RequiresThread]
        public void RequiresThreadTest()
        {
            
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
            Thread.CurrentThread.Name = "Tyss";
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }

    [TestFixture]
    [Category("RequiresThread")]
    public class RequiresThreadScript1
    {
       public RequiresThreadScript1()
        {
            Thread.CurrentThread.Name = "THis is the Current Thread";
        }

        [Test, RequiresThread]
        public void RequiresThreadTest()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
            Console.WriteLine(Thread.CurrentThread.Name);
        }
        [Test]
        public void RequiresThreadScript2()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
            Console.WriteLine(Thread.CurrentThread.Name);
        }

        [Test]
        public void RequiresThreadScript3()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
