using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Pages;
using System;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumNUnitCsharp.Driver;

namespace SeleniumNUnitCsharp.Tests.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();
            driver = new WebDriverSetup().GetWebDriver("Chrome");
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