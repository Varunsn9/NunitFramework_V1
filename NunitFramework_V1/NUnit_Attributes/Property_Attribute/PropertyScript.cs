using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Property_Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    //attributetargets to methods only// we can use this attribute only for tests
    //if we want to use for class / enums etc // we should add or '|' and add another Attribute targets like class
    public class SeverityAttribute : PropertyAttribute
            //we use propert attribute to create a custom attribute
            //this attribute can only be utilized for tests
    {
        public SeverityAttribute(Severitylevel severitylevel) : base()
        {
            Console.WriteLine(severitylevel.ToString());
        }
    }
    public enum Severitylevel
    {
        Critical,
        Major,
        Normal,
        Minor
    }

    [TestFixture]

    public class PropertyScript
    {
        [Test]
        [Severity(Severitylevel.Minor)]
        [Category("Property")]
        public void PropertyTest()
        {
            TestContext.WriteLine($"{TestContext.CurrentContext.Test.Name}");
            Thread.Sleep(5000);
        }
    }
}
