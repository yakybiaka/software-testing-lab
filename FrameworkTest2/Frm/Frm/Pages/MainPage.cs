using Frm.Driver;
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
        public IWebElement buttonSelectPassengers;

        [FindsBy(How = How.XPath, Using = "//*[@class='numptc1']//*[@class='l-border do-min1']")]
        public IWebElement buttonDecrementAdults;

        [FindsBy(How = How.XPath, Using = "//*[@class='numptc1']//*[@class='r-border do-max1']")]
        public IWebElement buttonIncrementAdults;

        [FindsBy(How = How.XPath, Using = "//span[@class='numptc1']")]
        public IWebElement PassengersAdultsValue;

        [FindsBy(How = How.XPath, Using = "//span[@class='numptc3']")]
        public IWebElement ChildrensAdultsValue;

        [FindsBy(How = How.XPath, Using = "//*[@class='numptc3']//*[@class='l-border do-min3']")]
        public IWebElement buttonDecrementAdultsChildrens;

        [FindsBy(How = How.XPath, Using = "//*[@class='numptc3']//*[@class='r-border do-max3']")]
        public IWebElement buttonIncrementAdultsChildrens;

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
            origin.Clear();
            origin.SendKeys(departureCity);          
        }

        public void EnterCityOfArrival(string arrivalCity)
        {
            destination.Clear();
            destination.SendKeys(arrivalCity);         
        }

        public void EnterDepartureBackDate(string date)
        {
           depStrDate.Clear();
            depStrDate.SendKeys(date);
            origin.SendKeys(Keys.Enter);
        }

        public void EnterDepartureDate(string date)
        {
            retStrDate.Clear();
            retStrDate.SendKeys(date);
            origin.SendKeys(Keys.Enter);
        }

        public ResultPage ClickSearchTicket()
        {
            buttonSearchTicket.Click();
            return new ResultPage(DriverInstance.GetInstance());
        }

        public void ClickAddHardRate()
        {
            buttonHardRate.Click();
        }

        public void ClickAddFly()
        {
            buttonAddFly.Click();
        }

        public void ClickSelectPassenger()
        {
            buttonSelectPassengers.Click();
        }
    }
}
