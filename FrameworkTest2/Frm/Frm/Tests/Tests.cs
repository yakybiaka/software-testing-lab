using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test] //1
        public void CheckFilterWork()
        {
            var departDay = DateTime.Now.AddDays(-2);
            var arrivDay = DateTime.Now;
            steps.OpenMainPage();

            steps.EnterCities("Минск", "Москва");

            steps.EnterDate(departDay, arrivDay);

            Assert.AreEqual(true, steps.CheckFiltersWork());
        }

        [Test] //2
        public void CheckDateChecking()
        {
            var departDay = DateTime.Now;
            var arrivDay = DateTime.Now.AddDays(5);

            steps.OpenMainPage();

            steps.EnterCities("Минск","Москва");

            steps.EnterDate(departDay, arrivDay);

            Assert.AreEqual(true, steps.CheckWinError());
        }

        [Test] //3
        public void CheckAdultsPassengersDecrement()
        {
            steps.OpenMainPage();

            steps.SelectPassengers();

            steps.DecrementAdultsPassengers();

            var value = steps.GetPassengersValue();
            Assert.AreEqual(value, 1);
        }

        [Test] //4
        public void CheckPassengerLimit()
        {
            steps.OpenMainPage();

            steps.SelectPassengers();

            for (int i = 0; i < 9; i++)
            {
                steps.IncrementAdultsPassengers();
            }

            var value = steps.GetPassengersValue();
            Assert.AreEqual(value, 9);
        }

        [Test] //5
        public void CheckFlyLimit()
        {
            steps.OpenMainPage();
            Assert.AreEqual(false, steps.CheckHardRate());
        }

        [Test] //6
        public void CheckSimilarCity()
        {
            var departDay = DateTime.Now;
            var arrivDay = DateTime.Now.AddDays(5);

            steps.OpenMainPage();

            steps.EnterCities("Минск","Минск");

            steps.EnterDate(departDay, arrivDay);

            Assert.AreEqual(true, steps.CheckWinError());
        }

        [Test] //7
        public void CheckThreeChildrenAndOneParent()
        {
            var departDay = DateTime.Now;
            var arrivDay = DateTime.Now.AddDays(5);

            steps.OpenMainPage();

            steps.EnterCities("Минск","Москва");

            steps.EnterDate(departDay, arrivDay);

            steps.SelectPassengers();

            for (int i = 0; i < 2; i++)
            {
                steps.IncrementAdultsPassengers();
            }

            for (int i = 0; i < 3; i++)
            {
                steps.IncrementAdultsChildrens();
            }

            for (int i = 0; i < 2; i++)
            {
                steps.DecrementAdultsPassengers();
            }

            Assert.AreEqual(true, steps.CheckWinError());
        }

        [Test] //8
        public void CheckAnotherAirports()
        {
            steps.OpenMainPage();
        }

        [Test] //9
        public void CheckTimeOutSession()
        {
            steps.OpenMainPage();
        }

        [Test] //10
        public void CheckExistenceCity()
        {
            var departDay = DateTime.Now;
            var arrivDay = DateTime.Now.AddDays(5);

            steps.OpenMainPage();

            steps.EnterCities("Массачупинс","Массачупинс");

            steps.EnterDate(departDay, arrivDay);

            Assert.AreEqual(false, steps.CheckListValue());
        }

        static void Main(string[] args)
        {
        }
    }
}

