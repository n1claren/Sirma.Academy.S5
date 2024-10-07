int n = int.Parse(Console.ReadLine());

int reversedNumber = 0;

while (n != 0)
{
    int remainder = n % 10;
    reversedNumber = reversedNumber * 10 + remainder;   
    n /= 10;  
}

Console.WriteLine(reversedNumber);