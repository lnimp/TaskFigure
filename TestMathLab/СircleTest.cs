using MathLib;

namespace TestMathLab
{
    [TestClass]
    public class СircleTest
    {
        [TestMethod]
        public void СircleSolution()
        {
            double radius = 6.7;
            double resultWait = 140.9546;

            Сircle circle = new Сircle(radius);
            double result = (double)circle.Execute();

            Assert.AreEqual(resultWait, result);
        }
    }
}
