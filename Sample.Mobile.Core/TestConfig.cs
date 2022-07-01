using System;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace Sample.Mobile.Core
{
    public static class TestConfig
    {
        public static IConfiguration ConfigurationBuilder
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true)
                    .AddJsonFile("appsettings.json", false, true)
                    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
                    .Build();
            }
        }

        public static string UserNumber
        {
            get { return ConfigurationBuilder[nameof(UserNumber)]; }
        }

        public static string Pin
        {
            get { return ConfigurationBuilder[nameof(Pin)]; }
        }

        public static string Device
        {
            get { return ConfigurationBuilder[nameof(Device)]; }
        }

        public static string OsVersion
        {
            get { return ConfigurationBuilder[nameof(OsVersion)]; }
        }

        public static string PlatformName
        {
            get { return ConfigurationBuilder[nameof(PlatformName)]; }
        }

        public static int DefaultTimeout
        {
            get { return int.Parse(ConfigurationBuilder[nameof(DefaultTimeout)]); }
        }

        public static string RemoteDriver
        {
            get { return ConfigurationBuilder[nameof(RemoteDriver)]; }
        }

        public static string LocalDriver
        {
            get { return ConfigurationBuilder[nameof(LocalDriver)]; }
        }

        public static string LocalDevice
        {
            get { return ConfigurationBuilder[nameof(LocalDevice)]; }
        }

        public static bool Local
        {
            get { return Convert.ToBoolean(ConfigurationBuilder[nameof(Local)]); }
        }

        public static string BrowserstackUser
        {
            get { return ConfigurationBuilder[nameof(BrowserstackUser)]; }
        }

        public static string BrowserstackKey
        {
            get { return ConfigurationBuilder[nameof(BrowserstackKey)]; }
        }

        public static string BrowserstackAppLink
        {
            get { return ConfigurationBuilder[nameof(BrowserstackAppLink)]; }
        }

        public static string AppPackage
        {
            get { return ConfigurationBuilder[nameof(AppPackage)]; }
        }

        public static string AppActivity
        {
            get { return ConfigurationBuilder[nameof(AppActivity)]; }
        }
    }
}