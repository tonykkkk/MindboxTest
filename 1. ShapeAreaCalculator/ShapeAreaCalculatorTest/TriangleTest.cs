using ShapeAreaCalculator;

namespace ShapeAreaTestProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestNormalTriangleArea()
        {
            var triangle = new Triangle(8, 4, 5);
            var area = triangle.CalculateArea();
            Assert.AreEqual(area, 8.1815340859767858);

        }
        [TestMethod]
        public void TestRightTriangleArea()
        {
            var triangle = new Triangle(5, 4, 3);
            var area = triangle.CalculateArea();
            Assert.AreEqual(area, 6);

        }
        [TestMethod]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(5, 4, 3);

            Assert.AreEqual(triangle.IsRight(), true);


        }
        [TestMethod]
        public void TestNotRightTriangle()
        {
            var triangle = new Triangle(8, 4, 5);
            var isRight = triangle.IsRight();
            Assert.AreEqual(isRight, false);


        }
        [TestMethod]
        [ExpectedException(typeof(ShapeArgumentException))]
        public void TestWrongArguments()
        {
            var triangle = new Triangle(3, 4, 8);
            var area = triangle.CalculateArea();

        }
        [TestMethod]
        [ExpectedException(typeof(ShapeArgumentException))]
        public void TestZeroArguments()
        {

            var triangle = new Triangle(3, 0, 5);
            var area = triangle.CalculateArea();

        }
        [TestMethod]
        [ExpectedException(typeof(ShapeArgumentException))]
        public void TestNegativeArguments()
        {
            var triangle = new Triangle(-4, -5, -3);
            var area = triangle.CalculateArea();



        }
    }
}
