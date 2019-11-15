using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesLib.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Area_ShouldReturnCorrectResult()
        {
            double expectedArea = 6;
            var resultArea = new Triangle(3, 4, 5).Area;
            Assert.AreEqual(expectedArea, resultArea);
        }

        [TestMethod]
        public void Name_ShouldReturnCorrectResult()
        {
            string expectedName = "Triangle";
            string resultName = new Triangle(1, 2, 3).Name;

            Assert.AreEqual(expectedName, resultName);
        }

        [TestMethod]
        public void IsRightTriangle_ShouldReturnTrue()
        {
            var isRightCondition = new Triangle(5, 4, 3).IsRight;
            Assert.IsTrue(isRightCondition);
        }

        [TestMethod]
        public void IsNotRightTriangle_ShouldReturnFalse()
        {
            var isRightCondition = new Triangle(3, 6, 4).IsRight;
            Assert.IsFalse(isRightCondition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void ZeroSide1_ShouldThrowException()
        {
            var triangle = new Triangle(0, 2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void MinusSide1_ShouldThrowException()
        {
            var triangle = new Triangle(-1, 2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void ZeroSide2_ShouldThrowException()
        {
            var triangle = new Triangle(1, 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void MinusSide2_ShouldThrowException()
        {
            var triangle = new Triangle(1, -2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void ZeroSide3_ShouldThrowException()
        {
            var triangle = new Triangle(1, 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Длина всех сторон треугольника должна быть > 0.")]
        public void MinusSide3_ShouldThrowException()
        {
            var triangle = new Triangle(1, 2, -3);
        }
    }
}
