using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class MainPage
    {
        IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string accountButtonField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[1]/div[3]/div[1]/a/span[2]";
        private const string shippingAndPayment = "//*[@id=\"top\"]/div/ul/li[2]/a";
        private const string specialMenuField = "//*[@id=\"bs-megamenu\"]/ul/li[1]/a";

        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

       

        [FindsBy(How = How.XPath, Using = shippingAndPayment)]
        public IWebElement ShippingAndPaymentButton { get; set; }

        [FindsBy(How = How.XPath, Using = specialMenuField)]
        public IWebElement specialMenuButton { get; set; }

        public MainPage ClickOnAccountField()
        {
            AccountButton.Click();
            return new MainPage(driver);
        }

       

        public ShippingAndPaymentPage CliclToShippingAndPaymentButton()
        {
            ShippingAndPaymentButton.Click();
            return new ShippingAndPaymentPage(driver);
        }

        public SpecialPage ClickMenuSpecialButton()
        {
            specialMenuButton.Click();
            return new SpecialPage(driver);
        }

        private const string newButtonField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[2]/div[1]/div/div/div[1]/a/span";
        private const string registrationButtonOnHeaderField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[1]/div[3]/div[1]/a/span[2]";


        [FindsBy(How = How.XPath, Using = newButtonField)]
        public IWebElement NewButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnHeaderField)]
        public IWebElement RegistrationButton { get; set; }

        public NewPage ClickOnNewField()
        {
            NewButton.Click();
            return new NewPage(driver);
        }
        public RegistrationPage ClickToRegistrationButton()
        {
            RegistrationButton.Click();
            return new RegistrationPage(driver);
        }


    }
}
