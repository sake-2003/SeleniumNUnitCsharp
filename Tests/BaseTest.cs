using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Pages;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnitCsharp.Tests.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
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