using Automation_Framework.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Automation_Framework.Helpers
{
    public class Configuration
    {
        private const string WebDriverConfigSectionName = "webdriver";
        private const string EnvironmentConfigSectionName = "environment";
        private const string AndroidDriverConfigSectionName = "android";
        private const string IOSDriverConfigSectionName = "ios";

        public static WebDriverConfiguration WebDriver =>
            Load<WebDriverConfiguration>(WebDriverConfigSectionName);
        public static AndroidDriverConfiguration AndroidDriver =>
           LoadAndroid<AndroidDriverConfiguration>(AndroidDriverConfigSectionName);
        public static IOSDriverConfiguration IOSDriver =>
             LoadIOS<IOSDriverConfiguration>(IOSDriverConfigSectionName);
        public static EnvironmentConfiguration Environment =>
         Load<EnvironmentConfiguration>(EnvironmentConfigSectionName);
        public static string DriverPath =>
         Path.Combine(System.Environment.CurrentDirectory, "Drivers");
        private static T Load<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                          .Build().GetSection(sectionName).Get<T>();
        }
        private static T LoadAndroid<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                        .Build().GetSection(sectionName).Get<T>();
        }
        private static T LoadIOS<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                        .Build().GetSection(sectionName).Get<T>();
        }
    }
}
