using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.PageObjects;

namespace DemoApp.Test.pages
{
    class ThomsonReutersPage
    {
        String test_url = "https://www.thomsonreuters.com/en.html";

        private IWebDriver driver;
        private WebDriverWait wait;

        public ThomsonReutersPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div#onetrust-close-btn-container")]
        [CacheLookup]
        public IWebElement cookies_close_item;

        [FindsBy(How = How.XPath, Using = "//span[text()='Careers']")]
        [CacheLookup]
        public IWebElement menu_item_careers_link;

        [FindsBy(How = How.XPath, Using = "//span[text()='See all jobs']")]
        [CacheLookup]
        public IWebElement submenu_item_see_all_jobs;

        [FindsBy(How = How.CssSelector, Using = "input#cws_jobsearch_keywords")]
        [CacheLookup]
        public IWebElement search_key;

        [FindsBy(How = How.CssSelector, Using = "a#cws-adv-search-btn")]
        [CacheLookup]
        public IWebElement search_btn;

        public void goToPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }

    }

}
