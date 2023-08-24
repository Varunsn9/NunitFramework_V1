using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly: Parallelizable(ParallelScope.All)]
//All the fixtures and test will execute parallel
//parallel Scope All can be provided in fixture or assembly

namespace NunitFramework_V1.NUnit_Attributes.Parallelizable_Attribute
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    //all the tests inside the fixture will execute parallel
    [Category("Parallelizable_All")]
    public class Parallelizable_All_Script 
    {
        [Test]
        public void Parallelizable_All_Test()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"start time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"end time {DateTime.Now}");
        }
        [Test]
        public void Parallelizable_All_Test1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"start time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"end time {DateTime.Now}");
        }
    }
}
