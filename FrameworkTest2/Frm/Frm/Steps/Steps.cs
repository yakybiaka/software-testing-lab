using Frm.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Steps
{
    class Steps
    {
        private IWebDriver driver;

        private MainPage _mainPage { get; set; }

        private ResultPage _resultPage { get; set; }
        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenMainPage()
        {
            _mainPage = new MainPage(driver);

            _mainPage.OpenPage();
        }

        public void EnterCities(string arrival, string departure)
        {
            _mainPage.EnterCityOfArrival(arrival);
            _mainPage.EnterCityOfArrival(departure);
        }

        public void EnterDate(DateTime date_depart, DateTime date_arrival)
        {
            var DayOfDep = Convert.ToString(date_depart.Date);
            var DayOfArriv = Convert.ToString(date_arrival.Date);
            _mainPage.EnterDepartureDate(DayOfDep);
            _mainPage.EnterDepartureBackDate(DayOfArriv);
        }


        public void DecrementAdultsPassengers()
        {
            _mainPage.buttonDecrementAdults.Click();
        }

        public void SelectPassengers()
        {
            _mainPage.buttonSelectPassengers.Click();
        }

        public void IncrementAdultsPassengers()
        {
            _mainPage.buttonIncrementAdults.Click();
        }

        public void DecrementAdultsChildrens()
        {
            _mainPage.buttonDecrementAdultsChildrens.Click();
        }

        public void IncrementAdultsChildrens()
        {
            _mainPage.buttonIncrementAdultsChildrens.Click();
        }

        public int GetPassengersValue()
        {
            return Convert.ToInt32(_mainPage.PassengersAdultsValue.Text);
        }

         public bool CheckHardRate()
        {
            _mainPage = new MainPage(driver);

            _mainPage.ClickAddHardRate();

            for (int i = 0; i < 4; i++)
            {
                _mainPage.ClickAddFly();
            }

            try
            {

                driver.FindElement(By.Id("state_input_m5"));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CheckWinError()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            return _resultPage.CheckErrorWindow();
        }

        public bool CheckFiltersWork()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            System.Threading.Thread.Sleep(10000);
            _resultPage.ClickButtonFilters();
            _resultPage.ClickOneTransplants();
            _resultPage.ClickTwoTransplants();
            _resultPage.ClickThreeTransplants();       
            return _resultPage.CheckAnotherTransplants();
        }


        public bool CheckListValue()
        {
            _mainPage = new MainPage(driver);
            
            try
            {
                driver.FindElement(By.Id("ui-menu-item"));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}

