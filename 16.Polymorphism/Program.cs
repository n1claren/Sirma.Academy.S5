using ShapeAreaCalculator;

List<Shape> shapes = new List<Shape>
{
    new Circle(5),
    new Rectangle(4, 6),
    new Triangle(5, 8)
};

foreach (Shape shape in shapes)
{
    Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.GetArea():F2}");
}