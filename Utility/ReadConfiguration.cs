using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Utility
{
    public class ReadConfiguration
    {
        private const string WebDriverConfigSectionName = "webdriver";
        private const string FilePath = @"..\..\..\TestSettings.json";
        private static readonly string SettingsPath = Path.Combine(Environment.CurrentDirectory, FilePath);

        public static WebDriverProperties WebDriver => ReadTestSettings<WebDriverProperties>(WebDriverConfigSectionName);
        private static T ReadTestSettings<T>(string sectionName)
        {
            return JObject.Parse(File.ReadAllText(SettingsPath)).SelectToken(sectionName).ToObject<T>();
        }
    }
}
