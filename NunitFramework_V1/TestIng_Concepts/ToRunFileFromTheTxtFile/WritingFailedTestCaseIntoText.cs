using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.TestIng_Concepts.ToRunFileFromTheTxtFile
{
    [TestFixture]
    [Category("TxtWrite")]
    public class WritingFailedTestCaseIntoText
    {
        StreamWriter fs;
        [OneTimeSetUp]
        public void OTSU()
        {
            string txt = $"C:\\NewDrive\\VisualStudioRepo\\NunitFramework_V1\\NunitFramework_V1\\TestIng_Concepts\\ToRunFileFromTheTxtFile\\{DateTime.Now.Hour}_{DateTime.Now.Minute}_FailedScript.txt";
            fs = new StreamWriter(txt);
            fs.WriteLine("# My Test List");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine($"{TestContext.CurrentContext.Test.Name}");
        }

        [Test]
        public void Test1()
        {
            Assert.Fail();
        }
        [Test]
        public void Test0()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Assert.Fail();
        }
        [TearDown]
        public void TestINGFile()
        {
            if (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure)) 
            { 
            fs.WriteLine(TestContext.CurrentContext.Test.FullName);
            fs.Flush();
            }
        }
        [OneTimeTearDown]
        public void OTTD()
        {
            fs.Close();
        }
    }
}
