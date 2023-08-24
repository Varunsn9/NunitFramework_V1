using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.NUnit_Attributes.Order_Attribute
{
    [TestFixture,Category("Order"),Order(1)]//we can provide the order attribute to the Fixture
                                            //utilize the nunit3-console "path of dll" --where=Category=Order
    public class OrderScript1
    {
        [Test,Order(1)]// we can provide the order attribute to the test
        public void Order1()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(2)]// we can provide the order attribute to the test
        public void Order2()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(0)]// we can provide the order attribute to the test
        public void Order0()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
    }
    [TestFixture, Category("Order"), Order(0)]//we can provide the order attribute to the Fixture
    public class OrderScript0
    {
        [Test, Order(1)]// we can provide the order attribute to the test
        public void Order1()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(2)]// we can provide the order attribute to the test
        public void Order2()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(0)]// we can provide the order attribute to the test
        public void Order0()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
    }
    [TestFixture, Category("Order"), Order(2)]//we can provide the order attribute to the Fixture
    public class OrderScript2
    {
        [Test, Order(1)]// we can provide the order attribute to the test
        public void Order1()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(2)]// we can provide the order attribute to the test
        public void Order2()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
        [Test, Order(0)]// we can provide the order attribute to the test
        public void Order0()
        {
            Console.WriteLine($"method name is {TestContext.CurrentContext.Test.FullName}");
            Thread.Sleep(1000);
        }
    }
}
