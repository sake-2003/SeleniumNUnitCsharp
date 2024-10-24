using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Pages;
using System;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumNUnitCsharp.Driver;
using OpenQA.Selenium.Edge;
using SeleniumNUnitCsharp.Utility;

namespace SeleniumNUnitCsharp.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            driver = new WebDriverSetup().GetWebDriver(ReadConfiguration.WebDriver);
            eCommerceHomePage = new HomePage(driver);
            eCommerceHomePage.GoTo();
        }

        [TearDown]

        public void TearDown()

        {
            driver.Quit();
            driver.Dispose();
        }

        public IWebDriver driver;
        protected HomePage eCommerceHomePage;
    }
}