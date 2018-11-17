using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageFactoryPattern
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            try
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }

        }


        [FindsBy(How = How.Id, Using = "state_input")]
        private IWebElement origin;

        [FindsBy(How = How.Id, Using = "state_input1")]
        private IWebElement destination;

        [FindsBy(How = How.Id, Using = "to")]
        private IWebElement depStrDate;

        [FindsBy(How = How.Id, Using = "from")]
        private IWebElement retStrDate;


        public SearchPage goToSearch()
        {
            origin.SendKeys("Minsk(MSQ)");
            destination.SendKeys("Washington(WSG)");
            depStrDate.SendKeys("11-17-2018");
            retStrDate.SendKeys("11-24-2018");
           return new SearchPage(driver);
        }
    }
}
