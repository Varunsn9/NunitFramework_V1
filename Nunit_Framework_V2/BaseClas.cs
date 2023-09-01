using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Framework_V2
{
    public class BaseClas : ITestListener
    {
        public void SendMessage(TestMessage message)
        {
            throw new NotImplementedException();
        }

        public void TestFinished(ITestResult result)
        {
            throw new NotImplementedException();
        }

        public void TestOutput(TestOutput output)
        {
            throw new NotImplementedException();
        }

        public void TestStarted(ITest test)
        {
            throw new NotImplementedException();
        }
    }
}
