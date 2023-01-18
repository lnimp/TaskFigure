using MathLib;

namespace TestMathLab
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleSolution()
        {
            double sideA = 5.2;
            double sideB = 3.4;
            double sideC = 7;
            double resultWait = 8.449;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double result = (double)triangle.Execute();

            Assert.AreEqual(resultWait, result);
        }
    }
}