using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesLib.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Area_ShouldReturnCorrectResult()
        {
            double expectedArea = Math.PI;
            var area = new Circle(1).Area;

            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void Name_ShouldReturnCorrectResult()
        {
            string expectedName = "Circle";
            string resultName = new Circle(1).Name;

            Assert.AreEqual(expectedName, resultName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Радиус круга не может быть <= 0.")]
        public void ZeroRadius_ShouldThrowException()
        {
            var circle = new Circle(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Радиус круга не может быть <= 0.")]
        public void MinusRadius_ShouldThrowException()
        {
            var circle = new Circle(-5);
        }
    }
}
