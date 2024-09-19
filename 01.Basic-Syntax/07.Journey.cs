double firstCarSpeed = double.Parse(Console.ReadLine());
double secondCarSpeed = double.Parse(Console.ReadLine());

double firstCarDistance = firstCarSpeed * 5;
double secondCarDistance = secondCarSpeed * 3;

double distanceBetween  = Math.Abs(firstCarDistance - secondCarDistance);

Console.WriteLine(distanceBetween);