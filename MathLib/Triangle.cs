namespace MathLib
{
    public class Triangle : IFigure
    {
        public string NameFigure { get => NameFigure; init => NameFigure = "Треугольник"; }
        double sideA, sideB, sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public Triangle(double[] sides)
        {
            if (sides.Length == 2)
            {
                this.sideA = sides[0];
                this.sideB = sides[1];
                this.sideC = sides[2];
            }
            else
            {
                throw new Exception("Не корректная длинна массива");
            }
        }
        public double Execute()
        {
            double perimeter = (sideA + sideB + sideC) / 2;
            double halfmeter = perimeter / 2;
            var result = perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC);
            result = Math.Sqrt(result);
            return  Math.Round(result,3);
            //√(p·(p - a)·(p - b)·(p - c))
        }
    }
}
