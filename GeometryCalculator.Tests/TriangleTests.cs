using System;

namespace GeometryCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = new Triangle(sideA, sideB, sideC);
            var expectedArea = 6.0;

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001, "Area should be correctly calculated for Triangle.");
        }

        [TestMethod]
        public void TestRightAngledTriangle()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act & Assert
            Assert.IsTrue(triangle.IsRightAngled(), "Triangle should be right-angled.");
        }
    }
}
