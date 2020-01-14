using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Models;

namespace GitHubAutomation.Pages
{
    class FAQPage
    {
        IWebDriver driver;

        public FAQPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string pageNameField = "/html/body/footer/div[2]/div/div/div[1]/div[2]/ul/li[1]/a";
        private const string searchTextField = "/html/body/div[1]/div/div[1]/div/div[2]/input";
        private const string searchButtonField = "/html/body/div[1]/div/div[1]/div/div[2]/span/i";

        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }

        [FindsBy(How = How.XPath, Using = searchTextField)]
        public IWebElement SearchTextInput { get; set; }

        [FindsBy(How = How.XPath, Using = searchButtonField)]
        public IWebElement SearchButton { get; set; }

        public FAQPage ClicSearchButton(Search search)
        {
            SearchTextInput.Clear();
            SearchTextInput.SendKeys(search.SearchText);
            SearchButton.Click();
            return new FAQPage(driver);
        }
    }
}
