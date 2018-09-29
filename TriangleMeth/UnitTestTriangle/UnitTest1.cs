using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestTriangle
{
    [TestClass]
    class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // Assert.Equals(false, TriangleCheck.);
          
            int a = -5;
            int b = 3;
            int c = 5;
            bool s = false;

            //TriangleCheck second = new TriangleCheck();
          //  bool actual = second.test(a, b, c);

            Assert.AreEqual(s, actual);
        }
    }
}
