using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Driver
{
    public class WebDriverConfiguration
    {
        public static ChromeOptions ChromeOptions()
        { 
            var options = new ChromeOptions();
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("start-maximized");

            return options;
        }

        public static EdgeOptions EdgeOptions()
        { 
            var options = new EdgeOptions();
            options.AddArgument("start-maximized");
            //options.AddArgument("headless");
            return options;
        }
    }
}
