using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://www.euroavia.ru/";

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger btn-lg buttonpoisk']")]
        private IWebElement buttonSearchTicket;

        [FindsBy(How = How.Id, Using = "state_input")]
        private IWebElement origin;

        [FindsBy(How = How.Id, Using = "state_input1")]
        private IWebElement destination;

        [FindsBy(How = How.Id, Using = "to")]
        private IWebElement depStrDate;

        [FindsBy(How = How.Id, Using = "from")]
        private IWebElement retStrDate;

        [FindsBy(How = How.XPath, Using = "//*[@class='input_text--button']")]
        public IWebElement BtnSelectPassengers;

        [FindsBy(How = How.XPath, Using = "//*[@class='numptc1']//*[@class='l-border do-min1']")]
        public IWebElement BtnDecrementAdults;

        [FindsBy(How = How.XPath, Using = "//span[@class='numptc1']")]
        public IWebElement PassengersAdultsValue;

        [FindsBy(How = How.XPath, Using = "//a[@class='ch_to_hard']/font")]
        private IWebElement buttonHardRate;

        [FindsBy(How = How.XPath, Using = "//a[@class='add_button']")]
        private IWebElement buttonAddFly;


        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void EnterCityOfDeparture(string departureCity)
        {
            origin.SendKeys(departureCity);
        }

        public void EnterCityOfArrival(string arrivalCity)
        {
            destination.SendKeys(arrivalCity);
        }

        public void EnterDepartureDate(string twoDaysAgoDate)
        {
            depStrDate.SendKeys(twoDaysAgoDate);
        }

        public void EnterDepartureBackDate(string twoDaysAgoDate)
        {
            retStrDate.SendKeys(twoDaysAgoDate);
        }

        public void ClickSearchTicket()
        {
            buttonSearchTicket.Click();
        }

        public void ClickAddHardRate()
        {
            buttonHardRate.Click();
        }

        public void ClickAddFly()
        {
            buttonAddFly.Click();
        }
    }
}
