using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[assembly:LevelOfParallelism(4)]//level of parallelism should be used in assembly
                                // this code will be executed in assembly level
                                //utilizing along with parallelizable 
                                //should need to provide the number of workers 

namespace NunitFramework_V1.NUnit_Attributes.LevelOfParallelism_Attribute
{
    [TestFixture,Category("LevelOfParallelism")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class LevelOfParallelismScript
    {
        [Test]
        public void ParallelExecution()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
        [Test]
        public void ParallelExecution1()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
        [Test]
        public void ParallelExecution2()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
        [Test]
        public void ParallelExecution3()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
        [Test]
        public void ParallelExecution4()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
        [Test]
        public void ParallelExecution5()
        {
            Thread.Sleep(5000);
            TestContext.WriteLine($"method name is {TestContext.CurrentContext.Test.Name} and dateAndTime {DateTime.Now}");
        }
    }
}
