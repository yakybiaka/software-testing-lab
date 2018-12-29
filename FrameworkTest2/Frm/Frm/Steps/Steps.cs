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

        public void EnterCitiesOnMainPage()
        {
            _mainPage.EnterCityOfArrival("Минск");
            _mainPage.EnterCityOfArrival("Москва");
        }

        public void EnterDateOnMainPage()
        {
            _mainPage.EnterDepartureDate("15-01-2019");
            _mainPage.EnterDepartureBackDate("29-01-2019");
        }

            public void EnterSimilarCities()
        {
            _mainPage.EnterCityOfArrival("Минск");
            _mainPage.EnterCityOfArrival("Минск");
        }

        public void EnterNonexistentCity()
        {
            _mainPage.EnterCityOfArrival("Минск");
            _mainPage.EnterCityOfArrival("Муссучипинс");
        }

        public void EnterYesterdayDate()
        {
            _mainPage.EnterDepartureDate("28-12-2018");
            _mainPage.EnterDepartureBackDate("15-01-2019");
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

