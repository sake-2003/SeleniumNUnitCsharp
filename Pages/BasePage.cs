using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver) 
        {
            Driver = driver;   
        }
        public IWebDriver Driver { get; set; }
    }
}
