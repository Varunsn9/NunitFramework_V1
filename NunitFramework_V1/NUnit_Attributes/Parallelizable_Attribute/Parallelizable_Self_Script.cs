using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Parallelizable_Attribute
{
    [TestFixture]
    //to use parallel execution with set of threads/workers we should use {LevelOfParallelism(int value)}
    [Parallelizable(ParallelScope.Self)]
    //when we use parallelScope.self in fixture all the test present inside the fixture will execute parallel
    //when there are multiple fixture with parallelscope.self the fixture will execute each methods parallel
    //one test after another
    
        [Category("Parallelizable_Self_Fixture")]
        public class Parallelizable_Self_Script
        {
            [Test]
            public void Parallelizable_Self_Test()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
                Thread.Sleep(5000);
            }
            [Test]
            public void Parallelizable_Self_Test1()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
                Thread.Sleep(5000);
            }
        }
        [TestFixture]
        //to use parallel execution with set of threads/workers we should use {LevelOfParallelism(int value)}
        [Parallelizable(ParallelScope.Self)]
        //when we use parallelScope.self in fixture all the test present inside the fixture will execute parallel
        [Category("Parallelizable_Self_Fixture")]
        public class Parallelizable_Self_Script_Fixture2
        {
            [Test]
            public void Parallelizable_Self_Test()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
                Thread.Sleep(5000);
            }
            [Test]
            public void Parallelizable_Self_Test1()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.FullName);
                Thread.Sleep(5000);
            }
        }
        [TestFixture]
        [Category("Parallelizable_Self_Test")]
        public class Parallelizable_Self_Script_Test
        {
            [Test]
            [Parallelizable(ParallelScope.Self)]//parallel methods will execute at the end
            public void Parallelizable_Self_Utilizing()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
                TestContext.WriteLine($"Start Time {DateTime.Now}");
                TestContext.WriteLine("method utilizing parallelscope.self");
                Thread.Sleep(5000);
                TestContext.WriteLine($"End Time {DateTime.Now}");
            }
            [Test]
            [Parallelizable(ParallelScope.Self)]
            public void Parallelizable_Self_Utilizing1()
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
                TestContext.WriteLine($"Start Time {DateTime.Now}");
                TestContext.WriteLine("method utilizing parallelscope.self");
                Thread.Sleep(5000);
                TestContext.WriteLine($"End Time {DateTime.Now}");
            }
            [Test]
            public void Parallelizable_Self_NotUtilizing()//test method will execute first
            {
                TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
                TestContext.WriteLine($"Start Time {DateTime.Now}");
                TestContext.WriteLine("method which is not utilizing parallelscope.self");
                Thread.Sleep(5000);
                TestContext.WriteLine($"End Time {DateTime.Now}");
            }
        }
}
