using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using DemoApp.Test.pages;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        ThomsonReutersPage thomsonReutersPage;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            thomsonReutersPage = new ThomsonReutersPage(driver);

        }
        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}


        [Test]
        public void Test1()
        {
            thomsonReutersPage.goToPage();

            thomsonReutersPage.cookies_close_item.Click();
            thomsonReutersPage.menu_item_careers_link.Click();
            thomsonReutersPage.submenu_item_see_all_jobs.Click();
            thomsonReutersPage.search_key.SendKeys("qa");
            thomsonReutersPage.search_btn.Click();

            //Assert.Pass();
        }
    }
}