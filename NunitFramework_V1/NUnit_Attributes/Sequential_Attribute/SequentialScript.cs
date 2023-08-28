using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Sequential_Attribute
{
    [TestFixture]
    [Category("Sequential")]
    public class SequentialScript
    {
        [Test,Sequential]
        //values will be executed sequential order one by one unlike combinations
        // check pairwise and combinatorial attributes
        public void Sequential_Attribute([Values(1, 2, 3, 4)] int a, [Values("a", "b")] string b)
        {
            TestContext.WriteLine($"{a} {b}");
            TestContext.WriteLine(TestContext.Parameters["Url"]);
        }
    }
}
