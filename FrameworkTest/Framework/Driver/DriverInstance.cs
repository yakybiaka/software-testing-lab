﻿using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Framework.Driver
{
    public class DriverInstance
    {
        private static IWebDriver driver;

        private DriverInstance() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }    
}
