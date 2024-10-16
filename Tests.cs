using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumNUnitCsharp
{
    [TestFixture, Category("Test")]
    public class Tests:BaseTest
    {
        [Test]
        public void Test()
        {
            var title = driver.Title;

            if (title == "BrowserStack")
            {
                Assert.Pass();
            }
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //ChromeDriver driver = new ChromeDriver();
           
            //driver.Close();
        }
 
        
    }
}