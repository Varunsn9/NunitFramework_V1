using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Range_Attribute
{
    [TestFixture]
    [Category("Range")]
    public class RangeScript
    {
        [Test]
        public void Range_Attribute([Range(1,10)] int a)
        {
            TestContext.WriteLine(a);
        }
    }
}
/*
public RangeAttribute(int from, int to);
public RangeAttribute(int from, int to, int step);
public RangeAttribute(long from, long to, long step);
public RangeAttribute(float from, float to, float step);
public RangeAttribute(double from, double to, double step);
 */