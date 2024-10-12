string[] commands = Console.ReadLine().Split(',');

int[] numbers = new int[0];

int currentNumber = 1;

for (int i = 0; i < commands.Length; i++)
{
    if (commands[i] == "add")
    {
        int[] newNumbers = new int[numbers.Length + 1];

        for (int z = 0; z < numbers.Length; z++)
        {
            newNumbers[z] = numbers[z];
        }

        newNumbers[numbers.Length] = currentNumber;
        numbers = newNumbers;
    }
    else if (commands[i] == "remove")
    {
        if (numbers.Length > 0)
        {
            int[] newNumbers = new int[numbers.Length - 1];

            for (int z = 0; z < newNumbers.Length; z++)
            {
                newNumbers[z] = numbers[z];
            }

            numbers = newNumbers;
        }
    }

    currentNumber++;
}

if (numbers.Length > 0)
{
    Console.WriteLine(string.Join(" ", numbers));
}
else
{
    Console.WriteLine("Empty");
}