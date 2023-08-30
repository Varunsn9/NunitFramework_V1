using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.TestFixture_Attribute
{
    [TestFixture("admin","password")]
    [Category("TestFixtureParameters")]
    public class ParatermizedTestFixtureScript
    {
        public string userName;
        public string passWord;
        public ParatermizedTestFixtureScript(string username, string password)
        {
            userName=username; passWord=password;
        }

        [Test]
        public void Test()
        {
            TestContext.WriteLine(userName); TestContext.WriteLine(passWord);
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
