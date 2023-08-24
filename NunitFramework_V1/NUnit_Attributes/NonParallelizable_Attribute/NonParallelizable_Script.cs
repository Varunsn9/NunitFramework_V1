using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly:Parallelizable(ParallelScope.All)]
namespace NunitFramework_V1.NUnit_Attributes.NonParallelizable_Attribute
{
    [TestFixture]
    [NonParallelizable]
    //the test inside the fixture Will not be Execute parallel
    [Category("NonParallelizable_Fixture")]
    public class NonParallelizable_Script
    {
        [Test]
        public void NonParallelizable_Attribute()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
        [Test]
        public void NonParallelizable_Attribute1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
    }
    [TestFixture]
    [Category("NonParallelizable_Fixture")]
    public class NonParallelizable_Script1
    {
        [Test]
        [NonParallelizable]
        // the non parallelizable attribute will execute last after all the test executes parallel
        public void NonParallelizable_Attribute()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine("Utilizing nonParallelizable attribute");
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
        [Test]///this test is going to execute first
        public void NonParallelizable_Attribute1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine("not utilizing the nonparallelizable attribute");
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }

        [Test]//this test is going to execute first
        public void NonParallelizable_Attribute2()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine("not utilizing the nonparallelizable attribute");
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
    }
}