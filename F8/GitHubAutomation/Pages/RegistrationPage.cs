using Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class RegistrationPage
    {
        IWebDriver driver;
        
        public RegistrationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

       
        private const string WelcomeEmailField = "/html/body/div[1]/div/div[1]/div[3]/div[1]/div/div/form/div[1]/div/input";
        private const string SignInButtonField = "/html/body/div[1]/div/div[1]/div[3]/div[1]/div/div/button/div[1]";
        private const string ErrorEmailField = "/html/body/div[1]/div/div[1]/div[3]/div[1]/div/div/form/div[2]/p[1]";

        [FindsBy(How = How.XPath, Using = SignInButtonField)]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = WelcomeEmailField)]
        public IWebElement WelcomeEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = ErrorEmailField)]
        public IWebElement ErrorEmail { get; set; }


        public RegistrationPage ClickOnSignInButton(Registration person)
        {
            WelcomeEmailInput.Clear();
            WelcomeEmailInput.SendKeys(person.EMail);
            SignInButton.Click();
            return new RegistrationPage(driver);
        }

    }
}
