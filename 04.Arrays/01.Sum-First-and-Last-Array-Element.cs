string input = Console.ReadLine();

int[] array = input.Split(',').Select(x => int.Parse(x)).ToArray();

int firstNumber = array[0];
int secondNumber = array[array.Length - 1];

Console.WriteLine(firstNumber + secondNumber);