using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.TestCaseSource_Attribute
{
    [TestFixture]
    [Category("TestCaseSource")]
    public class TestCaseSourceScript
    {
        [TestCaseSource(nameof(DivideCases_))]
        //when we are using the testcasesource we dont need to use Test attribute
        //the method or a property returning data /parameter should be same as the number of arguments
        // we can test data using excel sheet for data driven testing
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        public static object[] DivideCases =
        {
        new object[] { 12, 3, 4 },
        new object[] { 12, 2, 6 },
        new object[] { 12, 4, 3 }
        };
        public static IEnumerable<object[]> DivideCases_()
        {
            yield return new object[] { 10,2,5};
            yield return new object[] { 10, 3, 3 };
            yield return new object[] { 10, 4, 2 };
        }
    }
}
