using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.MaxTime_Attribute
{
    [TestFixture,Category("MaxTime")]
    public class MaxTimeScript
    {
        [Test]
        [MaxTime(2000)]//if a test exceeds the MaxTime The script will fail even though the assertion is passing
                        //It will not stop the execution          
        public void MaxTime()
        {
            Thread.Sleep(5000);
            Assert.Pass(TestContext.CurrentContext.Result.StackTrace);
        }
    }
}
