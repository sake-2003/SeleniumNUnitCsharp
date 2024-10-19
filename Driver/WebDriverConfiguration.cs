using OpenQA.Selenium.Chrome;
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
    }
}
