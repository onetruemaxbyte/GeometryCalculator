using System;

namespace GeometryCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            // Arrange
            var radius = 5.0;
            var circle = new Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            // Act
            var actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001, "Area should be correctly calculated for Circle.");
        }   
    }
}
