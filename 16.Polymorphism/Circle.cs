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
            return Radius * Radius * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
