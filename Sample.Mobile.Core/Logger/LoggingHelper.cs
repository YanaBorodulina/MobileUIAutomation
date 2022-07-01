﻿using System;
using log4net;
using log4net.Config;

namespace Sample.Mobile.Core.Logger
{
    public class LoggingHelper
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(LoggingHelper));

        public static void ConfigureFilePath(string filePathPart)
        {
            var logger = LogManager.GetLogger("TestLogAppender"); 
            GlobalContext.Properties["LogFileFolder"] = $"{filePathPart}/";

            XmlConfigurator.Configure();
        }

        public static void LogInformation(string message)
        {
            Log.Info(message);
        }

        public static void LogDebug(string message)
        {
            Log.Debug(message);
        }

        public static void LogError(string message, Exception exception = null)
        {
            message = "[ERROR]: " + message;

            if (exception != null) Log.Error(message, exception);
            else Log.Error(message);
        }
    }
}