using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace SeleniumNUnitCsharp.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver) 
        {
            Driver = driver;
            //js = (IJavaScriptExecutor)driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        //public IJavaScriptExecutor js { get; set; }

        public IWebElement LocateElement(By locator) => Driver.FindElement(locator);
        public void Click(By locator) => LocateElement(locator).Click();
        public void SetText(By locator, string text) => LocateElement(locator).SendKeys(text);
        public bool IsElementDisplayed(By locator) => Wait.Until(ExpectedConditions.ElementIsVisible(locator)).Displayed;
        public IWebElement WaitElementToDisplay(By locator) => Wait.Until(ExpectedConditions.ElementIsVisible(locator));
 
    }
}
