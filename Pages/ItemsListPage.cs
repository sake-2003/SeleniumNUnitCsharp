using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Pages
{
    public class ItemsListPage : BasePage
    {
        public ItemsListPage(IWebDriver driver) : base(driver) { }

        public void ClickOnFirstItem()
        {
            IsElementDisplayed(cardList);
            IsElementDisplayed(firstItemLocator);
            
            var firstItemTitle = LocateElement(firstItemLocator).GetAttribute("Title").ToLower();

            Console.WriteLine(firstItemTitle);
            StringAssert.Contains("playstation 5", firstItemTitle, "First item does not contain searched item");
            Click(firstItemLocator);
        }

        private By cardList => By.Id("card-list");
        private By firstItemLocator => By.CssSelector("#card-list > div:nth-child(1) > div > div > a > div.multi--content--11nFIBL > div.multi--title--G7dOCj3");
    }
}
