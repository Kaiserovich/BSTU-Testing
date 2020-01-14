
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class LightningDealsPage
    {

        IWebDriver driver;

        public LightningDealsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string pageNameField = "/html/body/div[1]/div[1]/ul/li[2]";

        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }

    }
}
