using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace NunitFramework_V1.NUnit_Attributes.SingleThread_Attribute
{
    [SetUpFixture, SingleThreaded]
    //single threaded attribute will ensures all the execution are performed in a single thread
    // this attribute should be provided to a testfixture
    [Category("SingleThread")]
    public class SingleThreadScript
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
            TestContext.WriteLine($"{Thread.CurrentThread.Name}");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.WriteLine(Thread.CurrentThread.Name);
            driver.Quit();
            driver.Dispose();
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.FullName}");
        }
    }
}

