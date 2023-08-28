using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.SetUpFixture_Attribute
{
    [TestFixture]
    [Category("SingleThread")]
    public class SingleThreadTest
    {
        [Test]
        public void SingleThread()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
            TestContext.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
