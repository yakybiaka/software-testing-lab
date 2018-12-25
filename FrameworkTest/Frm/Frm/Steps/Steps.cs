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

        //public void DecrementAdultsPassengers()
        //{
        //    _mainPage.BtnSelectPassengers.Click();
        //    _mainPage.BtnDecrementAdults.Click();
        //}

        //public int GetPassengersValue()
        //{
        //    return Convert.ToInt32(_mainPage.PassengersAdultsValue.Text);
        //}

            
        public bool CheckHardRate()
        {
            _mainPage = new MainPage(driver);

            _mainPage.ClickAddHardRate();

            for (int i=0;i<4;i++)
            {
                _mainPage.ClickAddFly();
            }

            try
            {

                driver.FindElement(By.Id("state_input_m5"));
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
