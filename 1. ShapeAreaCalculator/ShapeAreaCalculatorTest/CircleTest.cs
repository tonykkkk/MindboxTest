using ShapeAreaCalculator;

namespace ShapeAreaCalculatorTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestNormal()
        {
            var circle = new Circle(42);
            var area = circle.CalculateArea();
            Assert.AreEqual(area, 5541.7694409323949);


        }
        [TestMethod]
        [ExpectedException(typeof(ShapeArgumentException))]
        public void TestZero()
        {
            var circle = new Circle(0);
            var area = circle.CalculateArea();



        }
        [TestMethod]
        [ExpectedException(typeof(ShapeArgumentException))]
        public void TestNegative()
        {
            var circle = new Circle(-42);
            var area = circle.CalculateArea();


        }
    }
}