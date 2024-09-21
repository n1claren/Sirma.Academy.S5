double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

if (operation == "add")
{
    Console.WriteLine(firstNumber + secondNumber);
}
else if (operation == "subtract")
{
    Console.WriteLine(firstNumber - secondNumber);
}
else if (operation == "multiply")
{
    Console.WriteLine(Math.Round((firstNumber * secondNumber), 2));
}
else if (operation == "divide")
{
    Console.WriteLine(Math.Round((firstNumber / secondNumber), 2));
}