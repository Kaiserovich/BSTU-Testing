using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class SearchPage
    {
        IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string pageNameField = "/html/body/div[1]/div[2]/div[2]/div/div[1]/h1";

        private const string newButtonField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[2]/div[1]/div/div/div[1]/a/span";


        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }

        [FindsBy(How = How.XPath, Using = newButtonField)]
        public IWebElement NewButton { get; set; }

        public NewPage ClickOnNewField()
        {
            NewButton.Click();
            return new NewPage(driver);
        }
    }
}
