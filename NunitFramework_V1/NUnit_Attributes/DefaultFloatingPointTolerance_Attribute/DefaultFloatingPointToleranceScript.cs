using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.DefaultFloatingPointTolerance_Attribute
{
    [TestFixture,Category("DefaultFloatingPointTolerance")]
    [DefaultFloatingPointTolerance(1)]
    public class DefaultFloatingPointToleranceScript
    {
        [Test]
        public void ComparisonUsingDefaultFloatingPointToleranceFromFixture()
        {
            // Passes due to the DefaultFloatingPointToleranceAttribute from the fixture.
            Assert.That(2f, Is.EqualTo((double)2));
            // it is passing because we are comparing float or double
        }

        [Test]
        public void ComparisonOfIntegersDoNotUseTolerance()
        {
            // Fails as DefaultFloatingPointTolerance only effects comparisons
            // of floats and doubles.
            Assert.That(1, Is.EqualTo(2));
            // it is failing because we are not comparing float or double
        }

        [Test]
        public void ComparisonUsingSpecificTolerance()
        {
            // Fails as 1 is not equal to 2 using the specified tolerance 0.
            Assert.That(1f, Is.EqualTo(2).Within(0));
            /*
             * here it is failing because
                Expected: 2 +/- 0
                But was:  1.0f
                Off by:   1.0d
            */
        }

        [Test]
        [DefaultFloatingPointTolerance(2)]
        public void ComparisonUsingDefaultFloatingPointToleranceFromTest()
        {
            // Passes due to the  DefaultFloatingPointTolerance from the test.
            Assert.That(2f, Is.EqualTo(4));
            /*
             * if we change 2f to 1f it gets fail
                  Expected: 4 +/- 2.0d
                  But was:  1.0f
                  Off by:   3.0d
             */
        }
    }
}
