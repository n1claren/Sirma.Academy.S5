namespace ShapeAreaCalculator
{
    public class Rhombus : Shape
    {
        public double FirstDiagonal { get; set; }

        public double SecondDiagonal { get; set; }

        public double Side { get; set; }

        public Rhombus(double d1, double d2, double side)
        {
            FirstDiagonal = d1;
            SecondDiagonal = d2;
            Side = side;
        }

        public override double GetArea()
        {
            return 0.5 * FirstDiagonal * SecondDiagonal;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
