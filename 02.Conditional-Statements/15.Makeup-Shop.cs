double renovationCost = double.Parse(Console.ReadLine());

int countOfPowders = int.Parse(Console.ReadLine());
int countOfLipsticks = int.Parse(Console.ReadLine());
int countOfSpirals = int.Parse(Console.ReadLine());
int countOfShadows = int.Parse(Console.ReadLine());
int countOfConcealers = int.Parse(Console.ReadLine());

double pricePowder = 2.60;
double priceLipstick = 3.00;
double priceSpiral = 4.10;
double priceShadows = 8.20;
double priceConcealer = 2.00;


double totalOrderPrice = (countOfPowders * pricePowder) +
                         (countOfLipsticks * priceLipstick) +
                         (countOfSpirals * priceSpiral) +
                         (countOfShadows * priceShadows) +
                         (countOfConcealers * priceConcealer);


int totalMakeupCount = countOfPowders + countOfLipsticks + countOfSpirals + countOfShadows + countOfConcealers;

if (totalMakeupCount >= 50)
{
    totalOrderPrice *= 0.75;
}

double shopProfit = totalOrderPrice * 0.90;

if (shopProfit >= renovationCost)
{
    double remainingMoney = shopProfit - renovationCost;

    Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
}
else
{
    double moneyNeeded = renovationCost - shopProfit;

    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
}