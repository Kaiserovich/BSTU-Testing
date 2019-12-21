using System;
using System.IO;
using Framework.Driver;

using Framework.Services;
using GitHubAutomation.Tests;
using GitHubAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Framework.Tests
{
    class ShopTests : TestConfig
    {
       
        [Test]
        public void CheckDailyNew()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                NewPage sPage = new MainPage(Driver).ClickOnNewField();
                Assert.AreEqual("Daily New", sPage.pageName.Text.Substring(0, 9));

            });
        }
      
        [Test]
        public void ErrorWhenSingInWithEmptyField()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                RegistrationPage rPage = new MainPage(Driver)
                         .ClickToRegistrationButton();
                rPage.ClickOnSignInButton(RegistrationCreator.WithAllProperties());
                Assert.AreEqual("Please enter your password.", rPage.ErrorEmail.Text);


            });
        }

        [Test]
        public void ErrorWhenCouponSubscribeEmptyField()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                MainPage sPage = new MainPage(Driver).ClickCouponSubsribe();
                Assert.AreEqual("Please enter an email address.", sPage.CouponErrorMessage.Text);

            });
        }


        [Test]
        public void CheckSearch()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                SearchPage sPage = new MainPage(Driver).InputSearch(SearchCreator.WithAllProperties()).ClickSearch();
                Assert.AreEqual("home", sPage.pageName.Text.Substring(0, 4));

            });
        }

        [Test]
        public void CheckInstagram()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                InstagramPage sPage = new MainPage(Driver).ClickInstagramButton();
                Assert.AreEqual("romwe_fashion", sPage.pageName.Text);

            });
        }

        [Test]
        public void CheckMore()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                MemberListPage sPage = new MainPage(Driver).ClickMore();
                Assert.AreEqual("Outfit", sPage.pageName.Text);

            });
        }

        [Test]
        public void CheckLightningDeals()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                LightningDealsPage sPage = new MainPage(Driver).ClickLightningDeals();
                Assert.AreEqual("LIGHTNING DEALS", sPage.pageName.Text);

            });
        }

        [Test]
        public void ChecAboutUs()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                AboutUsPage sPage = new MainPage(Driver).ClickAboutUsButton();
                Assert.AreEqual("ABOUT US", sPage.pageName.Text);

            });
        }

        [Test]
        public void CheckStatement()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                StatementPage sPage = new MainPage(Driver).ClickStatementButton();
                Assert.AreEqual("PRIVACY & COOKIE STATEMENT", sPage.pageName.Text);

            });
        }

        [Test]
        public void CheckFAQSearch()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.romwe.com/");
                FAQPage sPage = new MainPage(Driver).ClickFAQButton().ClicSearchButton(SearchCreator.WithAllProperties());
                Assert.AreEqual("FAQ", sPage.pageName.Text);

            });
        }


    }
}
