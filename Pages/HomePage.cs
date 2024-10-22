using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }


        /*public void GoTo() 
        {
            Driver.Navigate().GoToUrl(HomePage_URL);
        }*/
        public void GoTo() => Driver.Navigate().GoToUrl(HomePage_URL);
        public bool IsPageTitleCorrect() => Driver.Title.Equals(Title);
        public void DoNotSubscribe() {
            
            if (IsElementDisplayed(subsNotification)) { 
                Click(doNotAllowBtn);
            }
        }

        public By subsNotification = By.XPath("/html/body/div[6]/div");
        public By doNotAllowBtn = By.XPath("/html/body/div[6]/div/div[2]/div[3]/div[2]"); 

        private const string HomePage_URL = "https://www.aliexpress.com/";
        private const string Title = "AliExpress";

    }
}
