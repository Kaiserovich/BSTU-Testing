using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class InstagramPage
    {
        IWebDriver driver;

        public InstagramPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string pageNameField = "//*[@id=\"react-root\"]/section/main/div/header/section/div[1]/h1";

        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }
    }
}
