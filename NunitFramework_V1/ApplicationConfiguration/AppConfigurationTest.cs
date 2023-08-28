using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework_V1.ApplicationConfiguration
{
    [TestFixture]
    [Category("AppConfig")]
    public class AppConfigurationTest
    {
        public static void Config()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["username"].ToString());
            
        }

        [Test]
        public  void AppConfiguration()
        {
            
            var username = ConfigurationManager.AppSettings["username"];
            Console.WriteLine(ConfigurationManager.AppSettings["username"].ToString());
            Console.WriteLine(ConfigurationManager.ConnectionStrings["url"].ToString());
        }
    }
}
