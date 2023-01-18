namespace MathLib
{
    public class Сircle : IFigure
    {
        const double Pi = 3.14;
        private double radius;
        public string NameFigure { get => NameFigure; init => NameFigure = "Круг"; }
        public Сircle(double radius)
        {
            this.radius = radius;
        }
        public double Execute()
        {
            var result = Pi * Math.Pow(radius,2);
            return result;
        }
    }
}
