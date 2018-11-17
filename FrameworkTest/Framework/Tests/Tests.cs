using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private const string USERNAME = "yakubiaka";
        private const string PASSWORD = "yAkyuliya";
        private const int REPOSITORY_RANDOM_POSTFIX_LENGTH = 6;

        [Test]
        public void CanChooseDepDateBeforeTodayDate()
        {
            private Steps.Steps steps = new Steps.Steps();
    

        [Test]
        public void OneCanLoginGithub()
        {
            steps.EnterCities(USERNAME, PASSWORD);
            Assert.AreEqual(USERNAME, steps.GetLoggedInUserName());
        }
    }
}
