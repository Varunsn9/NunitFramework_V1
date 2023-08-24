using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly:Parallelizable(ParallelScope.Children)]
//when we provide this statement all the tests inside a project will execute parallel

namespace NunitFramework_V1.NUnit_Attributes.Parallelizable_Attribute
{
    [TestFixture]
    [Category("Parallelizable_Children_Fixture")]
    // when paralleScope in fixture is provided all the test in the fixtures will run parallel
    //parallelscope children can be provided for fixture and assemble only                        
    [Parallelizable(ParallelScope.Children)]
    public class Parallelizable_Children_Script
    {
            [Test]
            public void Parallelizable_Children_Test()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
                TestContext.WriteLine($"start time {DateTime.Now}");
                Thread.Sleep(5000);
                TestContext.WriteLine($"end time {DateTime.Now}");
            }
            [Test]
            public void Parallelizable_Children_Test1()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"start time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"end time {DateTime.Now}");
        }
        }
        [TestFixture]
        [Parallelizable(ParallelScope.Children)]
        [Category("Parallelizable_Children_Fixture")]
        public class Parallelizable_Children_Script_Fixture2
        {
            [Test]
            public void Parallelizable_Children_Test()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"start time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"end time {DateTime.Now}");
        }
            [Test]
            public void Parallelizable_Children_Test1()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
            TestContext.WriteLine($"start time {DateTime.Now}");
            Thread.Sleep(5000);
            TestContext.WriteLine($"end time {DateTime.Now}");
        }
        }
}
