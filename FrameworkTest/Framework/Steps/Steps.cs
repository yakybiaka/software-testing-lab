using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void EnterCities(string cityOfDeparture, string cityOfArrival)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.EnterCityOfDeparture(cityOfDeparture);
            mainPage.EnterCityOfArrival(cityOfArrival);
            mainPage.EnterDepartureDate("17.11.2018");
            mainPage.EnterDepartureBackDate("19.11.2018");
        }
    }
}
