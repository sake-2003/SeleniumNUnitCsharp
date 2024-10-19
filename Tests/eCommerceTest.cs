using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Pages;
using SeleniumNUnitCsharp.Tests.Tests;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumNUnitCsharp.Tests
{

    public class eCommerceTest : BaseTest
    {
        [SetUp]

        public void SetUp()
        {
            navBar = new NavigationBar(driver);
            itemsList = new ItemsListPage(driver);
        }

        [Test]
        public void SearchItemAndAddToCart()
        {

            eCommerceHomePage.IsPageTitleCorrect();
            navBar.searchItem(itemToSearch);
            itemsList.ClickOnMatchedItem();
            Thread.Sleep(10000);

        }

        private const string itemToSearch = "playstation 5";
        NavigationBar navBar;
        ItemsListPage itemsList;



    }
}