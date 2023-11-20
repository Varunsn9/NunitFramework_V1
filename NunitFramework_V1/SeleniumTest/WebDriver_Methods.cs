using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitFramework_V1.SeleniumTest
{
    [TestFixture]
    [Category("WebDriverMethodsAndProperties")]
    public class WebDriver_Methods
    {
        IWebElement element;
        IWebDriver driver;
        string url = "https://www.google.com";
        [SetUp]
        public void Launching_The_Browser()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        
        [Test]
        [Category("WedDriverProperties")]
        public void WedDriverProperties()
        {
            driver.Navigate().GoToUrl(url);

            string uRL = driver.Url;
            string pageSource = driver.PageSource;
            string currentWindowHandle = driver.CurrentWindowHandle;
            string title=driver.Title;
            ReadOnlyCollection<string> windowHandles=driver.WindowHandles;
            Console.WriteLine("url = "+uRL);
            Console.WriteLine("pageSource = "+pageSource);
            Console.WriteLine("Currentwindowhandles = " + currentWindowHandle);
            Console.WriteLine("title = " + title);
            foreach (string windowHandle in windowHandles)
            {
                Console.WriteLine("windowshandles = " + windowHandle);
            }
        }
        [Test]
        [Category("WebDriverMethods")]
        public void WebDriverMethods()
        {
            var displayed = element.Displayed;
            var enabled=element.Enabled;
            var size=element.Size;
            var text=element.Text;
            var location=element.Location;
            var selected=element.Selected;
            var tagName = element.TagName;
            element.Clear();
            element.Click();
            element.GetAttribute("string attribute");
            element.GetCssValue("get css value");
            element.Submit();
            element.GetProperty("propertyName");
            element.SendKeys("");
            
            
        }

        [TearDown]
        public void ClosingTheBrowser()
        {
            driver.Close();
        }
    }
}
