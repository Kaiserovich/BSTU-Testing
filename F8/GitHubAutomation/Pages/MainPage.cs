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

        private const string newButtonField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[2]/div[1]/div/div/div[1]/a/span";
        private const string registrationButtonOnHeaderField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[1]/div[3]/div[1]/a/span[2]";

        private const string couponSubscribeButtonField = "/html/body/footer/div[1]/div/button";
        private const string couponErrorMessageField = "/html/body/footer/div[1]/div/div[2]/p";

        private const string searchField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[2]/div[4]/div/div/form/div/input";
        private const string searchButtonField = "//*[@id=\"scroll-top-tag\"]/div[2]/div[1]/div/div[2]/div[4]/div/div/div/i";

        private const string instagramButtonField = "/html/body/footer/div[2]/div/div/div[2]/div/div[2]/div/div/a[1]/img";
        private const string moreButtonField = "/html/body/div[2]/div/div[1]/a";
        private const string lightningDealsButtonField = "/html/body/div[1]/div[8]/div/div[1]/a";
        private const string aboutUsButtonField = "/html/body/footer/div[2]/div/div/div[1]/div[1]/ul/li[1]/a";
        private const string faqButtonField = "/html/body/footer/div[2]/div/div/div[1]/div[2]/ul/li[1]/a";
        private const string StatementButtonField = "/html/body/footer/div[4]/a[1]";


        [FindsBy(How = How.XPath, Using = newButtonField)]
        public IWebElement NewButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnHeaderField)]
        public IWebElement RegistrationButton { get; set; }


        [FindsBy(How = How.XPath, Using = couponSubscribeButtonField)]
        public IWebElement CouponSubscribeButton { get; set; }


        [FindsBy(How = How.XPath, Using = couponErrorMessageField)]
        public IWebElement CouponErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = searchField)]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = searchButtonField)]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = instagramButtonField)]
        public IWebElement InstagramButton { get; set; }

        [FindsBy(How = How.XPath, Using = moreButtonField)]
        public IWebElement MoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = lightningDealsButtonField)]
        public IWebElement LightningDealsButton { get; set; }

        [FindsBy(How = How.XPath, Using = aboutUsButtonField)]
        public IWebElement AboutUsButton { get; set; }

        [FindsBy(How = How.XPath, Using = faqButtonField)]
        public IWebElement FAQButton { get; set; }

        [FindsBy(How = How.XPath, Using = StatementButtonField)]
        public IWebElement StatementButton { get; set; }

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

        public MainPage ClickCouponSubsribe()
        {
            CouponSubscribeButton.Click();
            return new MainPage(driver);
        }

        public MainPage InputSearch(Search search)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(search.SearchText);
            return new MainPage(driver);
        }

        public SearchPage ClickSearch()
        {
            SearchButton.Click();
            return new SearchPage(driver);
        }

        public InstagramPage ClickInstagramButton()
        {
            InstagramButton.Click();
            return new InstagramPage(driver);
        }

        public MemberListPage ClickMore()
        {
            MoreButton.Click();
            return new MemberListPage(driver);
        }

        public LightningDealsPage ClickLightningDeals()
        {
            LightningDealsButton.Click();
            return new LightningDealsPage(driver);
        }

        public AboutUsPage ClickAboutUsButton()
        {
            AboutUsButton.Click();
            return new AboutUsPage(driver);
        }

        public FAQPage ClickFAQButton()
        {
            FAQButton.Click();
            return new FAQPage(driver);
        }

        public StatementPage ClickStatementButton()
        {
            StatementButton.Click();
            return new StatementPage(driver);
        }





    }
}
