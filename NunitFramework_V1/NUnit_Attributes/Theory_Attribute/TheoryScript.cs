using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Theory_Attribute
{
    [TestFixture]
    [Category("Theory")]
    public class TheoryScript
    {
        [Datapoint]
        public string name = "varun";

        [Datapoint]
        public int id = 09;

        [Datapoint]
        public string names = "yousef";

        [Datapoint]
        public int ids = 05;



        [Theory]// are similar to the [Test]
        // we can achieve data driven 
        //theory should always hava parameter/arguments
        // we will be using theroy when we are using datapoint and DatapointSource
        public void TheoryMethod(string name, int id)
        {
            TestContext.WriteLine($"{name} {id}");
        }

        [Theory]// the test method will execute
        public void TheroyTEst()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.Name}");
        }
    }
}
