using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.TestIng_Concepts.FetchingDataFromResult
{
    public class BaseClass : ITestListener
    {
        public void TestStarted(ITest test)
        {
            TestContext.WriteLine($"Test started: {test.FullName}");
        }

        public void TestFinished(ITestResult result)
        {
            IWebDriver driver = new ChromeDriver();
            TestContext.WriteLine($"Test finished: {result.FullName}");
            TestContext.WriteLine($"Test outcome: {result.ResultState.Status}");


            if (result.ResultState.Status == TestStatus.Failed)
            {
                TestContext.WriteLine($"Failure message: {result.Message}");
                TestContext.WriteLine($"Failure stack trace: {result.StackTrace}");
            }
        }

        public void TestOutput(TestOutput output)
        {
            TestContext.Out.WriteLine($"Test output: {output.Text}");
        }



        public void TestFailed(ITestResult result)
        {
            TestContext.WriteLine($"Test failed: {result.FullName}");
            TestContext.WriteLine($"Failure message: {result.Message}");
            TestContext.WriteLine($"Failure stack trace: {result.StackTrace}");
            TestMessage testMessage = new TestMessage(result.Test.FullName, result.Test.Name, result.Test.Id);
            TestContext.WriteLine(testMessage.TestId);
        }

        public void TestPassed(ITestResult result)
        {
            TestContext.WriteLine($"Test passed: {result.FullName}");
        }

        public void TestSkipped(ITestResult result)
        {
            TestContext.WriteLine($"Test skipped: {result.FullName}");
            TestContext.WriteLine($"Skip reason: {result.Message}");
            TestMessage testMessage = new TestMessage(result.Test.FullName, result.Test.Name, result.Test.Id);
            TestContext.WriteLine(testMessage.TestId);
        }

        public void SendMessage(TestMessage message)
        {
            TestContext.WriteLine($"Skip reason: {message.Message}");
        }
    }
}
