string figure = Console.ReadLine();

if (figure == "square")
{
    double squareSide = double.Parse(Console.ReadLine());

    double squareFace = squareSide * squareSide;

    Console.WriteLine($"{squareFace:F2}");
}
else if (figure == "rectangle")
{
    double rectangleSideA = double.Parse(Console.ReadLine());
    double rectangleSideB = double.Parse(Console.ReadLine());

    double rectangleFace = rectangleSideA * rectangleSideB;

    Console.WriteLine($"{rectangleFace:F2}");
}
else if (figure == "circle")
{
    double circleRadius = double.Parse(Console.ReadLine());

    double circleFace = circleRadius * circleRadius * Math.PI;

    Console.WriteLine($"{circleFace:F2}");
}
else if (figure == "triangle")
{
    double triangleSide = double.Parse(Console.ReadLine());
    double triangleSideHeight = double.Parse(Console.ReadLine());

    double triangleFace = 0.5 * triangleSide * triangleSideHeight;

    Console.WriteLine($"{triangleFace:F2}");
}