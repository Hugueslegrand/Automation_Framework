using System;
using System.IO;
using System.Linq;
using System.Threading;
using Allure.Commons;
using Automation_Framework.Helpers;
using OpenQA.Selenium;



namespace Automation_Framework.Extensions.WebDriver
{
    public static class ScreenshotTaker
    {
 

        public static void TakeStandardScreenshot(this IWebDriver driver, string fileName)
        {
            driver.SaveScreenshot(fileName);
        }

        private static void SaveScreenshot(this IWebDriver driver, string fileName)
        {
            try
            {
                var fileNameSave = GetFileNameSave(fileName);
                var pathToFile = GetFilePath(GetFileNameSave(fileNameSave));

                driver.ScreenshotSave(pathToFile);

                AllureLifecycle.Instance.AddAttachment(pathToFile, fileNameSave);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Taking a screenshot failed: {ex.Message}");
            }
        }

    

        private static void ScreenshotSave(this IWebDriver driver, string pathToFile)
        {
            var screenshot = ((ITakesScreenshot)GetBaseDriver(driver)).GetScreenshot();
            screenshot.SaveAsFile(pathToFile, ScreenshotImageFormat.Png);
        }

        private static string GetFileNameSave(string fileName)
        {
            return Path.GetInvalidFileNameChars()
                .Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        private static string GetFilePath(string fileName)
        {
            var path = $"{Configuration.WebDriver.ScreenshotsPath}\\{fileName}{DateTime.Now:HH}";
            Directory.CreateDirectory(path);
            var pathToFile =
                $"{path}\\{GetFileNameSave(DateTime.UtcNow.ToLongTimeString())}_{Thread.CurrentThread.ManagedThreadId}.png";
            return pathToFile;
        }

        private static IWebDriver GetBaseDriver(IWebDriver driver)
        {
            if (driver is WebDriverListener webDriverListener)
            {
                return webDriverListener.WrappedDriver;
            }

            return driver;
        }
    }
}