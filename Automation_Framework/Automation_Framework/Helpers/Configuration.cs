using Automation_Framework.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Automation_Framework.Helpers
{
    public class Configuration
    {
        // initialized as webdriver
        private const string WebDriverConfigSectionName = "webdriver";

        // initialized as environment
        private const string EnvironmentConfigSectionName = "environment";

        // initialized as nativeMobile
        private const string NativeMobileDriverConfigSectionName = "nativeMobile";

        // initialized as webMobile
        private const string WebMobileDriverConfigSectionName = "webMobile";

        /// <summary>
        /// Load configuration file with section name webDriver  
        /// </summary>
        public static WebDriverConfiguration WebDriver =>
            Load<WebDriverConfiguration>(WebDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name nativeMobile
        /// </summary>
        public static NativeMobileDriverConfiguration NativeMobileDriver =>
           Load<NativeMobileDriverConfiguration>(NativeMobileDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name webMobile
        /// </summary>
        public static WebMobileDriverConfiguration WebMobileDriver =>
             Load<WebMobileDriverConfiguration>(WebMobileDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name environment  
        /// </summary>
        public static EnvironmentConfiguration Environment =>
         Load<EnvironmentConfiguration>(EnvironmentConfigSectionName);

        public static string DriverPath =>
         Path.Combine(System.Environment.CurrentDirectory, "Drivers");

        /// <summary>
        /// Choses the section to load based on the section name
        /// </summary>
        /// <param name="sectionName">The section that should be chosen</param>
        private static T Load<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                          .Build().GetSection(sectionName).Get<T>();
        }

    }
}
