using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitCsharp.Pages
{
    public class NavigationBar : BasePage
    {
        public NavigationBar(IWebDriver driver) : base(driver) { }
        
        public void searchItem(string text) {
        
            SetText(searchBarLocator, text);
            Click(submitBtnLocator);
        }

        private By searchBarLocator => By.Id("search-words");
        private By submitBtnLocator => By.ClassName("search--submit--2VTbd-T");
    }
    
}
