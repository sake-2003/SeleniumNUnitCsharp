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

        public void ClickOnMatchedItem()
        {

            var elements = Driver.FindElements(itemLocator);
            var theElement = elements.FirstOrDefault(e => e.Text.Contains("playstation 5"));

            if (theElement != null)
            {
                theElement.Click();
            }
            
        }

        By itemLocator => By.ClassName("multi--title--G7dOCj3");
    }
}
