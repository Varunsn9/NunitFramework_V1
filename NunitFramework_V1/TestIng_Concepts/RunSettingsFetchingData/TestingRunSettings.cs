using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.TestIng_Concepts.RunSettingsFetchingData
{
    [TestFixture]
    public class TestingRunSettings
    {
        [Test]
        public void RunSettings()
        {
            Console.WriteLine(TestContext.Parameters["Url"]);
        }

    }
}
