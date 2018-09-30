using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckTriangle;

namespace CheckTriangleTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Test_General_return_false()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(7,5,13);

            //assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_Right_return_true()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(3, 4, 5);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_x_minus10_return_false()
        {
           //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(-10, 2, 15);

            //assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_y_0_return_false()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(10, 0, 2);

            //assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_all_arguments_0_return_false()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(0, 0, 0);

            //assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_two_arguments_0_return_false()
        {
           //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(4, 0,0 );

            //assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_x_double_return_true()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(6.02, 7, 10);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_x_double_y_double_return_true()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(6.02, 7.00004, 10);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_string_y_ConvertToDouble_return_true()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(7, Convert.ToDouble(6.000012554), 10);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_all_argumens_7_return_true()
        {
            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Check_Triangle(7, 7, 7);

            //assert
            Assert.AreEqual(true, actual);
        }
    }
}
