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

            WaitElementToDisplay(subsNotification);
            Click(doNotAllowBtn);
        }

        private By subsNotification = By.CssSelector("._1u9ll");
        private By doNotAllowBtn = By.CssSelector((".Sk1_X"));

        private const string HomePage_URL = "https://www.aliexpress.com/";
        private const string Title = "AliExpress";

    }
}
