double change = double.Parse(Console.ReadLine());

int leva = (int)change;
int stotinki = (int)((change - leva) * 100);

int totalStotinki = leva * 100 + stotinki;

int twoLevCoin = 0;
int oneLevCoin = 0;
int fiftyStotinkiCoin = 0;
int twentyStotinkiCoin = 0;
int tenStotinkiCoin = 0;
int fiveStotinkiCoin = 0;
int twoStotinkiCoin = 0; 
int oneStotinkaCoin = 0;

while (totalStotinki >= 200)
{
    totalStotinki -= 200;
    twoLevCoin++;
}

while (totalStotinki >= 100)
{
    totalStotinki -= 100;
    oneLevCoin++;
}

while (totalStotinki >= 50)
{
    totalStotinki -= 50;
    fiftyStotinkiCoin++;
}

while (totalStotinki >= 20)
{
    totalStotinki -= 20;
    twentyStotinkiCoin++;
}

while (totalStotinki >= 10)
{
    totalStotinki -= 10;
    tenStotinkiCoin++;
}

while (totalStotinki >= 5)
{
    totalStotinki -= 5;
    fiveStotinkiCoin++;
}

while (totalStotinki >= 2)
{
    totalStotinki -= 2;
    twoStotinkiCoin++;
}

while (totalStotinki >= 1)
{
    totalStotinki -= 1;
    oneStotinkaCoin++;
}

Console.Write($"Our change is {leva} leva and {stotinki} stotinki.");

int totalCoinsUsed = twoLevCoin + oneLevCoin + fiftyStotinkiCoin + twentyStotinkiCoin + tenStotinkiCoin + fiveStotinkiCoin + twoStotinkiCoin + oneStotinkaCoin;

Console.Write($"The machine returns it to us with {totalCoinsUsed} coins: ");

bool firstCoin = true;

if (twoLevCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");

    }

    Console.Write($"{twoLevCoin} x 2 leva coin");

    firstCoin = false;
}
if (oneLevCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{oneLevCoin} x 1 lev coin");

    firstCoin = false;
}
if (fiftyStotinkiCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{fiftyStotinkiCoin} x 50 stotinki coin");

    firstCoin = false;
}
if (twentyStotinkiCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{twentyStotinkiCoin} x 20 stotinki coin");

    firstCoin = false;
}
if (tenStotinkiCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{tenStotinkiCoin} x 10 stotinki coin");

    firstCoin = false;
}
if (fiveStotinkiCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{fiveStotinkiCoin} x 5 stotinki coin");

    firstCoin = false;
}
if (twoStotinkiCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{twoStotinkiCoin} x 2 stotinki coin");

    firstCoin = false;
}
if (oneStotinkaCoin > 0)
{
    if (!firstCoin)
    {
        Console.Write(", ");
    }

    Console.Write($"{oneStotinkaCoin} x 1 stotinka coin");
}

Console.WriteLine(".");