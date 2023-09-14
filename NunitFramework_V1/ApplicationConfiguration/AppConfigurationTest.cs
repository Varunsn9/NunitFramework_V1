using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
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
        [Test,Order(1)]
        
        public void AppConfig()
        {
           // Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Configuration config = ConfigurationManager.OpenExeConfiguration("C:\\NewDrive\\VisualStudioRepo\\NunitFramework_V1\\NunitFramework_V1\\App.config");
           /* config.AppSettings.Settings.Add("username", "abhilash");
            config.AppSettings.Settings.Add("password", "Abhilashpassword");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
           */ var c = ConfigurationManager.AppSettings.AllKeys;
            
            Console.WriteLine(config.FilePath);

            foreach (var b in c)
            {
                Console.WriteLine($"{b} {ConfigurationManager.AppSettings[b]}");
            }
            
        }

        [Test]
        public  void AppConfiguration()
        {
          
        }
    }
}
