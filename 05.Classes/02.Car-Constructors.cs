using Classes;

int inputs = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

while (inputs > 0)
{
    List<string> input = Console.ReadLine().Split(" ").ToList();

    if (input.Count > 1)
    {
        Car temp = new Car(input[0], input[1], int.Parse(input[2]));

        cars.Add(temp);
    }
    else
    {
        Car temp = new Car(input[0]);

        cars.Add(temp);
    }

    inputs--;
}

foreach (Car car in cars)
{
    Console.WriteLine(car.carInfo());
}