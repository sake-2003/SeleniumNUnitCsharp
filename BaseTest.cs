using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnitCsharp
{
    public class BaseTest
    {
        public IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.browserstack.com/");
        }

        [TearDown]

        public void TearDown()

        {
            driver.Quit();
            driver.Dispose();
            
        }
    }
}