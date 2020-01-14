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

    }
}
