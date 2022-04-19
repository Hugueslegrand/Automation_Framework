using Automation_Framework.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Automation_Framework.Helpers
{
    /// <summary>
    /// Reader for config files
    /// </summary>
    public class Configuration
    {
        private const string WebDriverConfigSectionName = "webdriver";
        private const string EnvironmentConfigSectionName = "environment";
        private const string NativeMobileDriverConfigSectionName = "nativeMobile";
        private const string WebMobileDriverConfigSectionName = "webMobile";

        public static WebDriverConfiguration WebDriver =>
            Load<WebDriverConfiguration>(WebDriverConfigSectionName);

        public static NativeMobileDriverConfiguration NativeMobileDriver =>
           Load<NativeMobileDriverConfiguration>(NativeMobileDriverConfigSectionName);

        public static WebMobileDriverConfiguration WebMobileDriver =>
             Load<WebMobileDriverConfiguration>(WebMobileDriverConfigSectionName);

        public static EnvironmentConfiguration Environment =>
         Load<EnvironmentConfiguration>(EnvironmentConfigSectionName);

        public static string DriverPath =>
         Path.Combine(System.Environment.CurrentDirectory, "Drivers");

        private static T Load<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                          .Build().GetSection(sectionName).Get<T>();
        }

    }
}
