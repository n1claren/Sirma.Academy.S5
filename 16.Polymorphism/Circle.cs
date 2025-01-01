namespace ShapeAreaCalculator
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
