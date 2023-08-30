using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.TestCase_Attribute
{
    [TestFixture]
    [Category("TestCase")]
    public class TestCaseScript
    {
        
        [TestCase(1,"first_Itteration",'a')]
        //TestCase attribute is used for datadriven testing 
        //for each TestCase The testmethod will execute seperatly
        // if we are using TestCase we dont required to provide Test attribute
        [TestCase(2, "second_Itteration", 'b')]
        [TestCase(3, "third_Itteration", 'c')]
        public void TestAttribute(int a, string b,char c)
        {
            TestContext.WriteLine($"{a} {b} {c}");
        }

        
        [Category("TestCaseWithExpectedResult")]
        [TestCase(12, 3, ExpectedResult = 4)] //expectedResult Attribute
        [TestCase(12, 2, ExpectedResult = 6)]
        [TestCase(12, 4, ExpectedResult = 3)]
        public int DivideTest(int n, int d)
        {
            return n / d;
        }

    }
}
/* 
Author = sets the author of the test.
Category = provides a comma-delimited list of categories for this test.
Description = sets the description property of the test.
ExcludePlatform = specifies a comma-delimited list of platforms on which the test should not run.
ExpectedResult = sets the expected result to be returned from the method, which must have a compatible return type.
Explicit = is set to true in order to make the individual test case Explicit. Use Reason to explain why.
Ignore = causes the test case to be ignored and specifies the reason.
IgnoreReason = causes this test case to be ignored and specifies the reason.
IncludePlatform = specifies a comma-delimited list of platforms on which the test should run.
Reason = specifies the reason for not running this test case. Use in conjunction with Explicit.
TestName = provides a name for the test. If not specified, a name is generated based on the method name and the arguments provided. See Template Based Test Naming.
TestOf =specifies the Type that this test is testing
*/