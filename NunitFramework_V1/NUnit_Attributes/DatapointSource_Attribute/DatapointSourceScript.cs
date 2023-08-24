using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.DatapointSource_Attribute
{
    [TestFixture,Category("DatapointSource")]
    public class DatapointSourceScript
    {

        [DatapointSource]//just like {datapoint} {datapointSource} will be utilized for {Theory}
                           // perticular method or a property should return array type or IEnumerable type
                         //if multiple {DatapointSource} methods are returning the same type to the 
                         //theory then all the all the {DatapointSource} will be executed
                         // if any value is returning duplicates will not be executed mulitple times
        public string[] CollectionsGeneric()
        {
            string[] CollectionGeneric = {"List","Dictionary","SortedList","Queue", "Stack","HashSet" };
            return CollectionGeneric;
        }
        [DatapointSource]
        public static IEnumerable<string> CollectionNonGeneric() 
        {
            string[] CollectionNonGeneric = { "ArrayList", "SortedList", "Stack", "Queue", "Hashtable", "BitArray" };
            foreach (string collection in CollectionNonGeneric)
            {
                yield return collection;
            }
        }

        [Theory]
        public void DatapointScript(string collections)
        {
            TestContext.WriteLine(collections);
        }
    }
}
