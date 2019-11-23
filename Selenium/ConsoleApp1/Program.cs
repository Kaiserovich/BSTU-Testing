using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("D:\\Документы\\BSTU\\Тестирование ПО\\L4");
            //driver.Manage().Window.Maximize(); ;
            driver.Url = "https://www.romwe.com/";
            Console.Clear();
            try
            {
                Thread.Sleep(10000);

                //1
                driver.FindElement(By.XPath("//a[contains(@class,'nav-first-cate-1')]")).Click();

                //2
                driver.FindElement(By.XPath("//span[contains(@class,'j-cate-sec-in')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//a[contains(@href,'https://www.romwe.com')]")).Click();


            }
            catch (Exception) { }
           
            //var firstTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[1]")).GetAttribute("title");
            //var secondTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[2]")).GetAttribute("title");
            //var thirdTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/span")).GetAttribute("innerHTML");
            //var HierarchyNavigation = $"{firstTitle} {secondTitle} {thirdTitle}";
            //driver.Quit();
        }
    }
}
