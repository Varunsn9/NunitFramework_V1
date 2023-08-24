using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Property_Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class SeverityAttribute : PropertyAttribute
    {
        public SeverityAttribute(Severitylevel severitylevel) : base(severitylevel.ToString()){  }
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
        [Test,Severity(severitylevel:Severitylevel.Minor)]
        [Category("Property")]
        public void Test()
        {
            TestContext.WriteLine("");
        }
    }
}
