using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Combinatorial_Attribute
{
    [TestFixture, Category("Combinatorial")]
    public class CombinatorialScript
    {
        [Test,Combinatorial]//used to validata all possible combination of individual data
        public void CombinatorialTest([Values(1, 2, 3)] int numbers, [Values('A', 'B')] char character)
        //here we need to use Values
        {
            Console.WriteLine(numbers + character);
        }
        /*
         * 1,A
         * 1,B
         * 2,A
         * 2,B
         * 3,A
         * 3,B    //all the possible combination
         */ 
    }
}
