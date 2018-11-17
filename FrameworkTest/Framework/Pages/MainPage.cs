using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class MainPage
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
    }
}
