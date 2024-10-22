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
            var firstItem = LocateElement(firstItemLocator);
            //Assert.IsTrue(firstItem.GetAttribute("Title").Equals("* playstation 5 *"));
            Click(firstItemLocator);
        }

        By cardList => By.Id("card-list");
        By firstItemLocator => By.CssSelector("#card-list > div:nth-child(1) > div > div > a > div.multi--content--11nFIBL > div.multi--title--G7dOCj3");

    }
}
