string columnName = Console.ReadLine();

int columnNameToNumber = 0;

for (int i = 0; i < columnName.Length; i++)
{
    columnNameToNumber *= 26;
    columnNameToNumber += columnName[i] - 'A' + 1;
}

Console.WriteLine(columnNameToNumber);