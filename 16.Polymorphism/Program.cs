using ShapeAreaCalculator;

List<Shape> shapes = new List<Shape>();

string command = String.Empty;

while (true)
{
    Console.WriteLine("Enter the type of figure you want to create. (circle, rectangle, rhombus, square or triangle)");
    Console.WriteLine("If you dont want to create any more figures, write 'calculate'");

    command = Console.ReadLine().ToLower();

    if (command == "calculate")
    {
        break;
    }

    switch (command.ToLower())
    {
        case "circle":
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            shapes.Add(circle);
            break;

        case "rectangle":
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(sideA, sideB);
            shapes.Add(rectangle);
            break;

        case "rhombus":
            double firstDiagonal = double.Parse(Console.ReadLine());
            double secondDiagonal = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            Rhombus rhombus = new Rhombus(firstDiagonal, secondDiagonal, side);
            shapes.Add(rhombus);
            break;

        case "square":
            double squareSide = double.Parse(Console.ReadLine());
            Square square = new Square(squareSide);
            shapes.Add(square);
            break;

        case "triangle":
            double @base = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double leftSide = double.Parse(Console.ReadLine());
            double rightSide = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(@base, height, leftSide, rightSide);
            shapes.Add(triangle);
            break;

        default:
            break;
    }
}

foreach (var shape in shapes)
{
    Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.GetArea():F2}");
    Console.WriteLine($"The perimeter of the {shape.GetType().Name} is {shape.GetPerimeter():F2}");
    Console.WriteLine();
}