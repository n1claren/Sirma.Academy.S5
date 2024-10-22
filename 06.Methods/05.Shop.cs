string product = Console.ReadLine();

int quantity = int.Parse(Console.ReadLine());

ShopBill(product, quantity);

static void ShopBill(string product, int quantity)
{
    double price = 0;

    if (product == "coffee")
    {
        price = 1.50;
    }
    else if (product == "water")
    {
        price = 1.00;
    }
    else if (product == "coke")
    {
        price = 1.40;
    }
    else if (product == "snacks")
    {
        price = 2.00;
    }

    price *= quantity;

    Console.WriteLine($"{price:F2}");
}