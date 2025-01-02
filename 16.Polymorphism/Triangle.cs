namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public double LeftSide { get; set; }

        public double RightSide { get; set; }

        public Triangle(double @base, double height, double ls, double rs)
        {
            Base = @base;
            Height = height;
            LeftSide = ls;
            RightSide = rs;
        }

        public override double GetArea()
        {
            return 0.5 * Height * Base;
        }

        public override double GetPerimeter()
        {
            return Base + LeftSide + RightSide;
        }
    }
}
