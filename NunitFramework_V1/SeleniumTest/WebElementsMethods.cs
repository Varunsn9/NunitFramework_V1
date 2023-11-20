using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitFramework_V1.SeleniumTest
{
    [TestFixture]
    [Category("WebElement")]
    public class WebElementsMethods
    {

        string url = "https://demo.actitime.com";
        IWebDriver driver;
        
        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new OperaConfig());
            driver = new OperaDriver();
        }

        [Test]
        [Category("WebElement_Text")]
        public void Text()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element= driver.FindElement(By.TagName("td"));
            Console.WriteLine(element.Text);
            /* 
             * if there is no text in the element it will return empty
             * if a locater finds multiple element it will return all the text 
             * if there is wrong address then it will return NoSuchElementException
             * return type is string
             */
        }

        [Test]
        [Category("WebElement_TagName")]
        public void TagName()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("username"));
            Console.WriteLine(element.TagName);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is string
             */
        }

        [Test]
        [Category("WebElement_Location")]
        public void Location()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("username"));
            Console.WriteLine(element.Location);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is Point
             */
        }

        [Test]
        [Category("WebElement_Displayed")]
        public void Displayed()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("username"));
            Console.WriteLine(element.Displayed);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is bool
             */
        }

        [Test]
        [Category("WebElement_Enabled")]
        public void Enabled()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("username"));
            Console.WriteLine(element.Enabled);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is bool
             */
        }

        [Test]
        [Category("WebElement_Selected")]
        public void Selected()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("remember"));
            //driver.FindElement(By.Name("remember")).Click();
            Console.WriteLine(element.Selected);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is bool
             */
        }

        [Test]
        [Category("WebElement_Size")]
        public void Size()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Name("remember"));
            Console.WriteLine(element.Size);
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is bool
             */
        }

        [Test]
        [Category("WebElement_Click")]
        public void Click()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id("toPasswordRecoveryPageLink"));
            element.Click();
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is void
             */
        }

        [Test]
        [Category("WebElement_Clear")]
        public void Clear()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id("username"));
            element.SendKeys("manager");
            Thread.Sleep(3000);
            element.Clear();
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is void
             */
        }

        [Test]
        [Category("WebElement_GetCssValue")]
        public void GetCssValue()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id("username"));
            string cssValue= element.GetCssValue("width");
            Console.WriteLine(cssValue);
            
            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is string
             */
        }

        [Test]
        [Category("WebElement_GetAttribute")]
        public void GetAttribute()
        {
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id("username"));
            string getAttribute = element.GetAttribute("class");
            Console.WriteLine(getAttribute);

            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is string
             */
        }


        [Test]
        [Category("WebElement_Submit")]
        public void Submit()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("hello");
            element.Submit();

            /* 
             * if there is wrong address then it will return NoSuchElementException
             * return type is void
             */
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(5000);
            driver.Close();
            driver.Dispose();
        }
    }
    [TestFixture]
    public class DataStructure
    {
        [Test,Category("ll")]
        public void LinkedListTesting()
        {
            LinkedList<string> ll=new LinkedList<string>();
            ll.AddLast("8");
            ll.AddFirst("0");
            var find=ll.Find("8");
            ll.AddAfter(find, "9");
            ll.AddBefore(find, "7");
            
            
            foreach (string s in ll)
            {
                Console.WriteLine(s);
            }
        }
        [Test,Category("AsyncAndAwait")]
        public void AsyncAndAwaittest1()
        {
            Method1();
            Method2();
            //Console.ReadKey();
        }

        public static async Task A()
        {
            await Task.Delay(1000);
            await Console.Out.WriteLineAsync("using await writeline async");
            await Task.Delay(1000);
        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
