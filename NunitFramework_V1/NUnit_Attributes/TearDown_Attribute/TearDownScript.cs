using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitFramework_V1.NUnit_Attributes.TearDown_Attribute
{
    [TestFixture]
    [Category("TearDown")]
    public class TearDownScript
    {
        IWebDriver driver;
        [Test]
        public void TestTearDownTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver=new ChromeDriver();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
        [Test]
        public void TestTearDownTest1()
        {

            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
        [TearDown]
        //this attribute will execute after each test execution
        //this attribute need inheritance from baseclass to utilize in the framework
        // we can provide multiple teardown's
        public void TestTearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
