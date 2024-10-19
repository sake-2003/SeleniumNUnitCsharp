using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
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
                   new DriverManager().SetUpDriver(new ChromeConfig());
                   var chromeDriver = new ChromeDriver(WebDriverConfiguration.ChromeOptions());
                   return chromeDriver;

                case "Firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxDriver = new FirefoxDriver();
                    return firefoxDriver;

                case "Edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeDriver = new EdgeDriver(WebDriverConfiguration.EdgeOptions());
                    return edgeDriver;

                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
