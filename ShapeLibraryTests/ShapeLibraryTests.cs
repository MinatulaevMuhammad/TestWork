using ShapeLibrary;

namespace ShapeLibraryTests
{
    public class ShapeLibraryTests
    {
        [Fact]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            Circle circle = new Circle(3);

            var area = circle.CalculateArea();

            Assert.Equal(Math.PI * 9, area);
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var area = triangle.CalculateArea();

            Assert.Equal(6, area);
        }

        [Fact]
        public void Triangle_IsRightAngle_ReturnsTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRightAngle = triangle.IsRightAngle();

            Assert.True(isRightAngle);
        }

        [Fact]
        public void Triangle_IsRightAngle_ReturnsFalseForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 6);

            var isRightAngle = triangle.IsRightAngle();

            Assert.False(isRightAngle);
        }

        [Fact]
        public void ShapeCalculator_CalculateArea_ReturnsCorrectArea()
        {
            var circle = new Circle(3);
            var triangle = new Triangle(3, 4, 5);

            var circleArea = ShapeCalculator.CalculateArea(circle);
            var triangleArea = ShapeCalculator.CalculateArea(triangle);

            Assert.Equal(Math.PI * 9, circleArea);
            Assert.Equal(6, triangleArea);
        }
    }
}