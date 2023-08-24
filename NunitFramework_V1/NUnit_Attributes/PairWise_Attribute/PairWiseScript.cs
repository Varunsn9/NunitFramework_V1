using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.PairWise_Attribute
{
    [TestFixture,Category("Pairwise")]// when we are using the pairwise it will execute in all the possible pair
                                      // combinatorial will execute 3*2*2
                                      // but pair wise will execute for the combination
    public class PairWiseScript
    {
        [Test,Pairwise]
        public void TestPairwise([Values(1,2,3)] int a, [Values(5,6)] int b, [Values(8,9)] int c)
        {
            TestContext.WriteLine($"{a} {b} {c}");
        }
    }
}
