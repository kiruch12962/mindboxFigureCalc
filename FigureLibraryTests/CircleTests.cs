using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Area_12_Return_452_3893()
        {
            //arrange
            Circle.Area(12);
            double expected = 452.3893;

            //act
            double result = Circle.Area(12);

            //assert
            Assert.AreEqual(expected, result);
        }


    }
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Area_2_4_5_Return_3_7997()
        {
            //arrange
            Triangle.Area(2, 4, 5);
            double expected = 3.7997;

            //act
            double result = Triangle.Area(2, 4, 5);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void isRectangular_2_4_5_Return_false()
        {
            //arrange
            Triangle.Rectangular(2, 4, 5);
            bool expected = false;

            //act
            bool result = Triangle.Rectangular(2, 4, 5);

            //assert
            Assert.AreEqual(expected, result);


        }
    }
}