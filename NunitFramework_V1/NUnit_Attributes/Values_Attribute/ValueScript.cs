using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Values_Attribute
{
    [TestFixture]
    [Category("Values")]
    public class ValueScript
    {
        [Test]
        public void ValuesTest([Values(1,2,3)] int a)
        {
            TestContext.WriteLine(a);
        }
        [Test]
        public void ValuesTestWithMultipleArguments([Values(1, 2, 3)] int a, [Values(1, 2, 3)] int b)
            //it will execute with all the possible combinations
        {
            TestContext.WriteLine($"{a}*{b}={a*b}");
        }
        [Test]//bool is of only two types true and false
        public void ValuesTestUSingBool([Values] bool val)
        {
            TestContext.WriteLine(val);
        }
        [Test]//all the enum will be utilized
        public void ValuesTestUSingEnum([Values] Days val)
        {
            TestContext.WriteLine((int)val);
        }
    }
    public enum Days 
    {
        Sunday=1,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,
    }
}
