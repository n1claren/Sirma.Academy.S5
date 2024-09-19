double firstCabinetPrice = double.Parse(Console.ReadLine());

double secondCabinetPrice = (firstCabinetPrice / 100) * 80;

double thirdCabinetPrice = ((firstCabinetPrice + secondCabinetPrice) / 100) * 115;

double totalPriceForAllThree = firstCabinetPrice + secondCabinetPrice + thirdCabinetPrice;

Console.WriteLine($"{totalPriceForAllThree:F3}");