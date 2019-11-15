using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesLib.Test
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TriangleArea_ShouldReturnCorrectResult()
        {
            double expectedArea = 6;
            var shape = new Shape(new Triangle(3, 4, 5));
            var resultArea = shape.Area;

            Assert.AreEqual(expectedArea, resultArea);
        }

        [TestMethod]
        public void CircleArea_ShouldReturnCorrectResult()
        {
            double expectedArea = Math.PI;
            var shape = new Shape(new Circle(1));
            var resultArea = shape.Area;

            Assert.AreEqual(expectedArea, resultArea);
        }
    }
}
