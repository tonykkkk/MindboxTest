using ShapeAreaCalculator;

namespace ShapeAreaTestProject
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void TestNormal()
        {
            var rightAnswers = new double[3] { 5541.7694409323949, 6, 8.1815340859767858 };


            var shapesList = new List<IShape>() {
                new Circle(42),
                new Triangle(3, 4, 5),
                new Triangle(8, 4, 5)
        };
            for (int i = 0; i < shapesList.Count; i++)
            {
                Assert.AreEqual(shapesList[i].CalculateArea(), rightAnswers[i]);
            }


        }
    }
}

