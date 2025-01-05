using ShapeAreaCalculator;

List<Shape> shapes = new List<Shape>();

string command = String.Empty;

while (true)
{
    Console.WriteLine("Enter the type of figure you want to create. (circle, rectangle, rhombus, square or triangle)");
    Console.WriteLine("If you dont want to create any more figures, write 'calculate'");
    Console.WriteLine("If you want to remove a figure, write 'remove'");

    command = Console.ReadLine().ToLower();

    if (command == "calculate")
    {
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

        int index = -1;

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out index) && index >= 0 && index < shapes.Count)
            {
                break;
            }
            else
            {
                Console.WriteLine("You entered an invalid index. Try again.");
            }
        }

        string nameOfRemovedFigure = shapes[index].GetType().Name;
        shapes.RemoveAt(index);
        Console.WriteLine($"Removed the {nameOfRemovedFigure} at index {index}");
    }

    switch (command.ToLower())
    {
        case "circle":
            double radius = 0;

            while (true)
            {
                Console.WriteLine("Please enter the radius of the circle:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The input you entered is not valid!");
                }
            }

            Circle circle = new Circle(radius);
            shapes.Add(circle);
            Console.WriteLine("Circle created!");
            break;

        case "rectangle":
            double sideA = 0;
            double sideB = 0;

            while (true)
            {
                Console.WriteLine("Please enter side A of rectangle:");
                string inputA = Console.ReadLine();
                bool isValidA = false;
                bool isValidB = false;

                if (double.TryParse(inputA, out sideA))
                {
                    isValidA = true;
                }

                Console.WriteLine("Please enter side B of rectangle:");
                string inputB = Console.ReadLine();

                if (double.TryParse(inputB, out sideB))
                {
                    isValidB = true;
                }

                if (isValidA && isValidB)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The input you entered is not valid!");
                }
            }

            Rectangle rectangle = new Rectangle(sideA, sideB);
            shapes.Add(rectangle);
            Console.WriteLine("Rectangle created!");
            break;

        case "rhombus":
            double firstDiagonal = 0;
            double secondDiagonal = 0;
            double side = 0;

            while (true)
            {
                Console.WriteLine("Please enter first rhombus diagonal:");
                string first = Console.ReadLine();
                bool isValidFirst = false;
                bool isValidSecond = false;
                bool isValidSide = false;

                if (double.TryParse(first, out firstDiagonal))
                {
                    isValidFirst = true;
                }

                Console.WriteLine("Please enter second rhombus diagonal:");
                string second = Console.ReadLine();

                if (double.TryParse(second, out secondDiagonal))
                {
                    isValidSecond = true;
                }

                Console.WriteLine("Please enter rhombus side:");
                string sideTemp = Console.ReadLine();

                if (double.TryParse(sideTemp, out side))
                {
                    isValidSide = true;
                }

                if (isValidFirst && isValidSecond && isValidSide)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The input you entered is not valid!");
                }
            }

            Rhombus rhombus = new Rhombus(firstDiagonal, secondDiagonal, side);
            shapes.Add(rhombus);
            Console.WriteLine("Rhombus created!");
            break;

        case "square":
            double squareSide = 0;

            while (true)
            {
                Console.WriteLine("Please enter the side of the square:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out squareSide))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The input you entered is not valid!");
                }
            }

            Square square = new Square(squareSide);
            shapes.Add(square);
            Console.WriteLine("Square created!");
            break;

        case "triangle":
            double @base = 0;
            double height = 0;
            double leftSide = 0;
            double rightSide = 0;

            while (true)
            {
                Console.WriteLine("Please enter the triangle base:");
                string baseTemp = Console.ReadLine();
                bool isValidBase = false;
                bool isValidHeight = false;
                bool isValidLeftSide = false;
                bool isValidRightSide = false;

                if (double.TryParse(baseTemp, out @base))
                {
                    isValidBase = true;
                }

                Console.WriteLine("Please enter the triangle height:");
                string heightTemp = Console.ReadLine();

                if (double.TryParse(heightTemp, out height))
                {
                    isValidHeight = true;
                }

                Console.WriteLine("Please enter triangle left side:");
                string leftSideTemp = Console.ReadLine();

                if (double.TryParse(leftSideTemp, out leftSide))
                {
                    isValidLeftSide = true;
                }

                Console.WriteLine("Please enter triangle right side:");
                string rightSideTemp = Console.ReadLine();

                if (double.TryParse(rightSideTemp, out rightSide))
                {
                    isValidRightSide = true;
                }

                if (isValidBase && isValidHeight && isValidLeftSide && isValidRightSide)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The input you entered is not valid!");
                }
            }

            Triangle triangle = new Triangle(@base, height, leftSide, rightSide);
            shapes.Add(triangle);
            Console.WriteLine("Triangle created!");
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