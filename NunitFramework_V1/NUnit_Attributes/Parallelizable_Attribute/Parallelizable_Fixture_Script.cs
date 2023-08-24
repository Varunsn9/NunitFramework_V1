using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly:Parallelizable(ParallelScope.Fixtures)]
//all the fixture inside the project will be executed parallel
namespace NunitFramework_V1.NUnit_Attributes.Parallelizable_Attribute
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    //fixture will execute parallel
    //Parallel Scope can only be provided to Fixture and Assembly
    [Category("Parallelizable_Fixture")]
    public class Parallelizable_Fixture_Script
    {
        [Test]
        public void Parallelizable_Fixture_Test()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
        [Test]
        public void Parallelizable_Fixture_Test1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
    }
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    [Category("Parallelizable_Fixture")]
    public class Parallelizable_Fixture_Script1
    {
        [Test]
        public void Parallelizable_Fixture_Test()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
        [Test]
        public void Parallelizable_Fixture_Test1()
        {
            TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"Start Time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"End Time {DateTime.Now}");
        }
    }
}
