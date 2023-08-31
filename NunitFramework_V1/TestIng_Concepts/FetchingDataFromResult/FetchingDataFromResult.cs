using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.TestIng_Concepts.FetchingDataFromResult
{
    public class FetchingDataFromResult : ITestListener
    {
       
        public void SendMessage(TestMessage message)
        {
           // throw new NotImplementedException();
        }

        public void TestFinished(ITestResult result)
        {
            //throw new NotImplementedException();
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);
            IWebDriver webDriver = new ChromeDriver();
        }

        public void TestOutput(TestOutput output)
        {
            //throw new NotImplementedException();
           
        }

        public void TestStarted(ITest test)
        {
            //throw new NotImplementedException();
        }
    }
}
