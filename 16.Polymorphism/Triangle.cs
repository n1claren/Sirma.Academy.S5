namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * Height * Base;
        }
    }
}
