using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Sel_Test
{
    class Program
    {
        [Test]
        static void Main(string[] args)
        {
            bool state = false;

            try
            {
                IWebDriver chrome = new ChromeDriver();
                chrome.Navigate().GoToUrl("https://www.euroavia.ru");

                chrome.FindElement(By.Id("state_input")).Clear();
                chrome.FindElement(By.Id("state_input1")).Clear();

                chrome.FindElement(By.Id("from")).SendKeys("26-12-2018");

                chrome.FindElement(By.Id("to")).SendKeys("27-12-2018");

                chrome.FindElement(By.Id("state_input1")).SendKeys("Минск");
                
                chrome.FindElement(By.Id("state_input")).SendKeys("Минск");

                System.Threading.Thread.Sleep(3000);

                chrome.FindElement(By.ClassName("buttonpoisk")).Click();

                var error = chrome.FindElement(By.ClassName("alert-danger"));

                if(error != null)
                {
                    state = true;
                }

                Assert.AreEqual(true, state);
            }
            
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
