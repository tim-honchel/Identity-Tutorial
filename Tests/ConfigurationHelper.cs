using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ConfigurationHelper
    {
        private const string ConfigSection = "ConnectionStrings:AuthConnectionString";
        private const string AppSetting = "appsettings.json";

        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder().AddJsonFile(AppSetting).Build();
        }

        public static string GetApplicationConnectionString()
        {
            var config = GetIConfigurationRoot();

            return config[ConfigSection];
        }
    }
}
