using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[Category(Category_namespace)] //error
//attributes cannot be declare to the namespace
namespace NunitFramework_V1.NUnit_Attributes.Category_Attribute
{
    [TestFixture]
    [Category("CategoryClass")]// Category attribute can be used in class level,
                          // it has one constructor which accepts string type
                          // if it is in class level all the methods inside the class will be cateroized 
    public class CategoryScript
    {
        [Test,Category("CategoryTest")]//Category attribute can be used in method level
        public void CategoryTest()
        {
            Console.WriteLine("Category Test");
        }   
    }
    
}
