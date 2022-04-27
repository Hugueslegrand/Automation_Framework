using Automation_Framework.Helpers;
using LLibrary;
using System;


namespace Automation_Framework.Utility
{
    public class Log
    {
        public static L logger = new L(directory: $@"{Configuration.WebDriver.LogsPath}");

		public static void StartTestCase(String sTestCaseName)
		{
			
			logger.Info("****************************************************************************************");

			logger.Info("****************************************************************************************");

			logger.Info("$$$$$$$$$$$$$$$$$$$$$$$$          " + sTestCaseName + "          $$$$$$$$$$$$$$$$$$$$$$$$");

			logger.Info("****************************************************************************************");

			logger.Info("****************************************************************************************");

		}

		public static void EndTestCase(String sTestCaseName)
		{

			logger.Info("XXXXXXXXXXXXXXXXXXXXXXX             " + "-E---N---D-" + "             XXXXXXXXXXXXXXXXXXXXXX");

			logger.Info("X");

			logger.Info("X");

			logger.Info("X");

			logger.Info("X");

		}

		

		public static void Info(String message)
		{

			logger.Info(message);

		}

		public static void Warn(String message)
		{

			logger.Warn(message);

		}

		public static void Error(String message)
		{

			logger.Error(message);

		}

		public static void Fatal(String message)
		{

			logger.Fatal(message);

		}

		public static void Debug(String message)
		{

			logger.Debug(message);

		}

	}
}

