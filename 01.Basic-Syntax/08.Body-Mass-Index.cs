double weight = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double BMI = weight / (height * height);

Console.WriteLine(Math.Round(BMI, 2));