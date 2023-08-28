using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitFramework_V1.NUnit_Attributes.Retry_Attribute
{
    [TestFixture]
    [Category("Retry")]
    public class RetryScript
    {
        [Test]
        [Retry(5)]
        //this will execute and check retry 
        //use debug to check the execution
        // will not be reflected on test result and test explorer
        public void RetryTest()
        {
            Assert.AreEqual("123", "456");
        }
    }
}
