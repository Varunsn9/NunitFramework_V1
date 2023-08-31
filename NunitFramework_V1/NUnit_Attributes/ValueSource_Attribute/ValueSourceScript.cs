using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.ValueSource_Attribute
{
    [TestFixture]
    [Category("ValueSource")]
    public class ValueSourceScript
    {
        [Test]
        public void ValueSource_Attribute([ValueSource(nameof(ValueSourceMethod))] string v, [ValueSource(nameof(ArrayTest))] int a)
        //value source when ever we are using it the methods or properties should be static
        //execute in all the possible combinations
        {
                TestContext.WriteLine($"{v} {a}");
        }
        public static IEnumerable<string> ValueSourceMethod() 
        {
           yield  return "na";
            yield return "ma";
            yield return "si";
            yield return "va";
            yield return "ya";
        }
        public static int[] ArrayTest()
        {
            int[] a = new int[5];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            return a;
        }
    }
}
