﻿namespace ShapeAreaCalculator
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
