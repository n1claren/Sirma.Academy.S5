using System.Text.Json;
using ShapeAreaCalculator;

List<Shape> shapes = LoadShapes();

string command = string.Empty;

while (true)
{
    Console.WriteLine("Enter the type of figure you want to create. (circle, rectangle, rhombus, square, or triangle)");
    Console.WriteLine("If you don't want to create any more figures, write 'calculate'");
    Console.WriteLine("If you want to remove a figure, write 'remove'");

    command = Console.ReadLine().ToLower();

    if (command == "calculate")
    {
        SaveShapes(shapes);
        break;
    }

    if (command == "remove")
    {
        if (shapes.Count == 0)
        {
            Console.WriteLine("There are no figures to remove!");
            continue;
        }

        Console.WriteLine("Please enter the index of the figure you want to remove:");
        for (int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine($"Index {i} - figure: {shapes[i].GetType().Name} with an area of {shapes[i].GetArea():F2}");
        }

        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < shapes.Count)
        {
            string nameOfRemovedFigure = shapes[index].GetType().Name;
            shapes.RemoveAt(index);
            Console.WriteLine($"Removed the {nameOfRemovedFigure} at index {index}");
        }
        else
        {
            Console.WriteLine("You entered an invalid index. Try again.");
        }
    }

    switch (command)
    {
        case "circle":
            double radius = TryParseDouble("Please enter the radius of the circle:");
            shapes.Add(new Circle(radius));
            Console.WriteLine("Circle created!");
            break;

        case "rectangle":
            double sideA = TryParseDouble("Please enter side A of the rectangle:");
            double sideB = TryParseDouble("Please enter side B of the rectangle:");
            shapes.Add(new Rectangle(sideA, sideB));
            Console.WriteLine("Rectangle created!");
            break;

        case "rhombus":
            double firstDiagonal = TryParseDouble("Please enter the first diagonal of the rhombus:");
            double secondDiagonal = TryParseDouble("Please enter the second diagonal of the rhombus:");
            double side = TryParseDouble("Please enter the side of the rhombus:");
            shapes.Add(new Rhombus(firstDiagonal, secondDiagonal, side));
            Console.WriteLine("Rhombus created!");
            break;

        case "square":
            double squareSide = TryParseDouble("Please enter the side of the square:");
            shapes.Add(new Square(squareSide));
            Console.WriteLine("Square created!");
            break;

        case "triangle":
            double @base = TryParseDouble("Please enter the triangle base:");
            double height = TryParseDouble("Please enter the triangle height:");
            double leftSide = TryParseDouble("Please enter the left side of the triangle:");
            double rightSide = TryParseDouble("Please enter the right side of the triangle:");
            shapes.Add(new Triangle(@base, height, leftSide, rightSide));
            Console.WriteLine("Triangle created!");
            break;

        default:
            Console.WriteLine("Invalid command. Try again.");
            break;
    }
}

foreach (var shape in shapes)
{
    Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.GetArea():F2}");
    Console.WriteLine($"The perimeter of the {shape.GetType().Name} is {shape.GetPerimeter():F2}");
    Console.WriteLine();
}

void SaveShapes(List<Shape> shapes)
{
    string json = JsonSerializer.Serialize(shapes, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("shapes.json", json);
    Console.WriteLine("Shapes saved to 'shapes.json'.");
}

List<Shape> LoadShapes()
{
    if (File.Exists("shapes.json"))
    {
        string json = File.ReadAllText("shapes.json");
        return JsonSerializer.Deserialize<List<Shape>>(json) ?? new List<Shape>();
    }
    return new List<Shape>();
}

double TryParseDouble(string message)
{
    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out double result))
        {
            return result;
        }

        Console.WriteLine("Invalid input. Please try again.");
    }
}