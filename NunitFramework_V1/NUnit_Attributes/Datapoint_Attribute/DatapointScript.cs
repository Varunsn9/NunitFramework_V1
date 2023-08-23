using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Datapoint_Attribute
{
    [TestFixture]
    [Category("Datapoint")]
    public class DatapointScript
    {
        [Datapoint] //providing data for the {Theroy} all the theories will execute 
                    //cannot be used for {Test}
        public char a = 'a';
        [Datapoint]
        public char b = 'b';
        [Datapoint]
        public char c = 'c';

        [Theory]//this method will execute 3 times for each datapoint
        public void DatapointTest(char values)
        {
            Console.WriteLine(values);
        }
    }
}
