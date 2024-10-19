using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnitCsharp.Driver
{
    public class DriverSetup
    {
        public IWebDriver GetWebDriver(string BrowserName)
        {
            IWebDriver driver;
            
            switch (BrowserName)
            {
                case "Chrome":
                   new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                   driver = new ChromeDriver(WebDriverConfiguration.ChromeOptions());
                   return driver;
                
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
