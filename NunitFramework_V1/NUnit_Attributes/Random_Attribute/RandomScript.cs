using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Random_Attribute
{
    [TestFixture]
    [Category("Random")]
    public class RandomScript
    {
        [Test]
        public void TestRandomScript([Random(0,7,10)] int a)
        {
            Console.WriteLine(a);
        }
    }
}
/*
public Random(int count);
public Random(int min, int max, int count);
public Random(uint min, uint max, int count);
public Random(long min, long max, int count);
public Random(ulong min, ulong max, int count);
public Random(short min, short max, int count);
public Random(ushort min, ushort max, int count);
public Random(byte min, byte max, int count);
public Random(sbyte min, sbyte max, int count);
public Random(double min, double max, int count);
public Random(float min, float max, int count);
*/