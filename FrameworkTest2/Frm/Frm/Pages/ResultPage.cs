using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Pages
{
    class ResultPage
    {
        private const string BASE_URL = "https://www.euroavia.ru/";

        [FindsBy(How = How.Id, Using = "this_date")]
        private IWebElement lowPriceCalendar;

        [FindsBy(How = How.XPath, Using = "//button[@class='price_button']")]
        private IWebElement priceButton;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), '1 пересадка')]")]
        private IWebElement oneTransplants;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), '2 пересадки')]")]
        private IWebElement twoTransplants;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), '3 пересадки')]")]
        private IWebElement threeTransplants;

        [FindsBy(How = How.Name, Using = "downlist")]
        private IWebElement buttonFilters;

        [FindsBy(How = How.XPath, Using = "//span[@class='stops']//*[@stops='0']")]
        private IWebElement stops;


        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool CheckAnotherTransplants()
        {
            bool exist = false;
            try
            {
                this.driver.FindElement(By.XPath("//span[text()='1 пересадка']"));
                this.driver.FindElement(By.XPath("//span[text()='2 пересадки']"));
                this.driver.FindElement(By.XPath("//span[text()='3 пересадки']"));
            }
            catch
            {
                exist = true;
            }
            return exist;
        }

        public bool CheckErrorWindow()
        {
            bool exist = true;
            try
            {
                this.driver.FindElement(By.XPath("//i[@class='icon-warning']"));
            }
            catch
            {
                exist = false;
            }
            return exist;
        }

        public void ClickOneTransplants()
        {
           oneTransplants.Click();
        }

        public void ClickTwoTransplants()
        {
            twoTransplants.Click();
        }

        public void ClickThreeTransplants()
        {
            threeTransplants.Click();
        }

        public void ClickButtonFilters()
        {
           buttonFilters.Click();
        }

    }
}
