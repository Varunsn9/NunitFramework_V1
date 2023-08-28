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

namespace NunitFramework_V1.NUnit_Attributes.SetUpFixture_Attribute
{
    [SetUpFixture]
    //all the fixtures should be in the same namespace
    //can only have onetimesetup and onetimeteardown
    // use debug mode to check the execution
    public class SetUpFixtureScript
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            driver.Dispose();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}
