using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitCsharp.Tests.Tests;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumNUnitCsharp.Tests
{

    public class eCommerceTest : BaseTest
    {
        [Test]
        public void Test()
        {
            var title = driver.Title;

            if (title == "Ali Express")
            {
                Assert.Pass();
            }

        }


    }
}