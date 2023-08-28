using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Repeat_Attribute
{
    [TestFixture]
    [Category("Repeat")]
    public class RepeatScript
    {

        [Test]
        [Category("Repeat")]
        [Repeat(10)]// this test will repeat multiple time but  
        public void RepeatTest()
        {
            Console.WriteLine("repeat");
        }
    }
}
