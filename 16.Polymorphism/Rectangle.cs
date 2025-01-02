namespace ShapeAreaCalculator
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
