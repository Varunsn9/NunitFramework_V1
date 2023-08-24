using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Explicit_Attribute
{
    [TestFixture,Category("Explicit")]
    [Explicit]//all the [test] inside the [TestFixture,Explicit]should be called explicitly
                //to run the explicit we can use category and run the explicit [Test]
                //nunit3-console "path of the dll" --where=category=Explicit
    public class ExplicitScript
    {
        [Test]
        public void Explicit_Attribute()
        {
            TestContext.WriteLine("ExplicitAttribute from ExplicitScript TestFixture");
        }
        [Test]
        public void Explicit_Attribute1()
        {
            TestContext.WriteLine("ExplicitAttribute from ExplicitScript TestFixture");
        }
    }
    [TestFixture, Category("Explicit")]
    public class ExplicitScript1
    {
        [Test, Category("Explicit")]
        [Explicit]//[Test] should be run explicitly 
        public void Explicit_Attribute()
        {
            TestContext.WriteLine("ExplicitAttribute from ExplicitScript1");
        }
        [Test]
        public void Explicit_Attribute1()
        {
            TestContext.WriteLine("not utilizing Explicit Attribute from ExplicitScript1");
        }
    }
}
