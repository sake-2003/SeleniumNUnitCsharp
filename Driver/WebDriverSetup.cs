using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnitCsharp.Driver
{
    public class WebDriverSetup
    {
        public IWebDriver GetWebDriver(string BrowserName)
        {
            //IWebDriver driver;
            
            switch (BrowserName)
            {
                case "Chrome":
                   new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                   var chromeDriver = new ChromeDriver(WebDriverConfiguration.ChromeOptions());
                   return chromeDriver;

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxDriver = new FirefoxDriver();
                    return firefoxDriver;

                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
