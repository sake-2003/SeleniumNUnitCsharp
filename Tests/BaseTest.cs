using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Pages;
using System;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumNUnitCsharp.Driver;
using OpenQA.Selenium.Edge;

namespace SeleniumNUnitCsharp.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new LegacyEdgeConfig());
            //driver = new EdgeDriver();
            driver = new WebDriverSetup().GetWebDriver("Edge");
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