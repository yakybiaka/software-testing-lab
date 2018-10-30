using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver chrome = new ChromeDriver();
                chrome.Url = "https://www.euroavia.ru";

                chrome.FindElement(By.Id("from")).SendKeys("11-12-2018");
                chrome.FindElement(By.Id("to")).SendKeys("15-12-2018");

                chrome.FindElement(By.Id("state_input1")).SendKeys("Милан");
               
            }
            
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
