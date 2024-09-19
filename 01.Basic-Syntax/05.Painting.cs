double totalPaintForAllRooms = double.Parse(Console.ReadLine());

double paintPerRoom = totalPaintForAllRooms / 3;

double redPaint = paintPerRoom / 13;
double yellowPaint = redPaint * 4;
double whitePaint = redPaint * 8;

Console.WriteLine($"Red: {Math.Round(redPaint, 4)}");
Console.WriteLine($"Yellow: {Math.Round(yellowPaint, 4)}");
Console.WriteLine($"White: {Math.Round(whitePaint, 4)}");

// The exercise asks for how much of each paint they used PER ROOM,
// but the output they provided shows results for all 3 rooms total.
// I solved for an individual room, because thats what the problem asks for.