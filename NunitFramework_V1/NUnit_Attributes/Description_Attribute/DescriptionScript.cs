﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: Description("Utilizing Description for Assembly")]
//description attribute can be utilized in assembly level 

namespace NunitFramework_V1.NUnit_Attributes.Description_Attribute
{
    [TestFixture]
    [Category("Description")]
    [Description("Utilizing Description for TestFixture")]
    //Description Attribute can be utilized for Test Fixture
    //This one will print in testresul file inside the xml file
    //use nunit3-console "path of the dll" --test="fullname of the fixture"
    public class DescriptionScript
    {
        [Test, Description("Utilizing Description for TestMethod")]
        //Description Attribute can be utilized for Test Method
        public void TestDescription()
        {
            TestContext.WriteLine(" TestMethod");
        }
        [Test, Description("Utilizing Description for TestMethod")]
        //Description Attribute can be utilized for Test Method
        public void TestDescription1()
        {
            TestContext.WriteLine(" TestMethod");
        }
    }
}
