using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Platform_Attribute
{
    [TestFixture]
    [Platform("NET-2.0")]//will not execute
    //we can provide for fixture and test
    [Category("Platform")]
    public class PlatformScript
    {
        [Test]
        [Platform("NET-2.0")]//will not execute
        public void PlatformScript_Test()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.MethodName}");
        }
        [Test]
        public void PlatformScript_Test1()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.MethodName}");
        }
    }

    //this platform attribute because the project is utilizing net 6.0 version // check in assembly
    //check the platform sintax and default values in following link
    //https://docs.nunit.org/articles/nunit/writing-tests/attributes/platform.html#test-syntax
    //utilize Commandline and to run nunit3-console "path of the dll" --where=category=Platform
    //if the platform is not matching version it will not execute in test explorer
    //to observe the result use command line and open the result file
    [TestFixture]
    [Platform("NET-6.0")]
    [Category("Platform")]
    public class PlatformScript_6_0
    {
        [Test]
        public void PlatformScript_Test()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.MethodName}");
        }
        [Test]
        public void PlatformScript_Test1()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.MethodName}");
        }

    }
}
