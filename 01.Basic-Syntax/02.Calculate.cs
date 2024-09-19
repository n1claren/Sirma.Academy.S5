using System.Text;

double numOne = double.Parse(Console.ReadLine());
double numTwo = double.Parse(Console.ReadLine());

double sumOfNumbers = numOne + numTwo;

double differenceBetweenNumbers = Math.Abs(numOne - numTwo);

double productOfNumbers = numOne * numTwo;

double averageOfNumbers = (numOne + numTwo) / 2;

StringBuilder result = new StringBuilder();

result.AppendLine($"The sum is: {sumOfNumbers}");
result.AppendLine($"The difference is: {differenceBetweenNumbers}");
result.AppendLine($"The product is: {productOfNumbers}");
result.AppendLine($"The average is: {averageOfNumbers}");

Console.WriteLine(result);