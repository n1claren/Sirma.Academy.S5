namespace ShapeAreaCalculator
{
    public class Rhombus : Shape
    {
        public double FirstDiagonal { get; set; }

        public double SecondDiagonal { get; set; }

        public Rhombus(double d1, double d2)
        {
            FirstDiagonal = d1;
            SecondDiagonal = d2;
        }

        public override double GetArea()
        {
            return 0.5 * FirstDiagonal * SecondDiagonal;
        }
    }
}
