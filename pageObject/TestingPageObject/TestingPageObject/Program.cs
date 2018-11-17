using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPageObject
{
    

    class Program
    {
        private const string url = "https://www.euroavia.ru/";
        private WebDriverWait wait;

        [Test]
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            HomePage homePage = new HomePage(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            SearchPage searchPage = homePage.goToSearch();

            Assert.AreEqual(true, searchPage.CheckUniqueAirline("Austrian"));

            driver.Quit();
        }
    }
}
