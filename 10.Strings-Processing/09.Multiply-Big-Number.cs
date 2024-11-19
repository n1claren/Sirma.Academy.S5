string largeNumber = Console.ReadLine();

int singleDigit = int.Parse(Console.ReadLine());

string result = MultiplyLargeNumber(largeNumber, singleDigit);

Console.WriteLine(result);

static string MultiplyLargeNumber(string largeNumber, int singleDigit)
{
    int carry = 0;

    string result = "";

    for (int i = largeNumber.Length - 1; i >= 0; i--)
    {
        int currentDigit = largeNumber[i] - '0';

        int product = currentDigit * singleDigit + carry;

        result = (product % 10) + result;

        carry = product / 10;
    }

    while (carry > 0)
    {
        result = (carry % 10) + result;
        carry /= 10;
    }

    return result;
}