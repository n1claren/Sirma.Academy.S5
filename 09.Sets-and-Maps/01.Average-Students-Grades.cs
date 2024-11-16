int numberOfInputs = int.Parse(Console.ReadLine());

SortedDictionary<string, List<double>> studentBook = new SortedDictionary<string, List<double>>();

for (int i = 0; i < numberOfInputs; i++)
{
    string[] currentInput = Console.ReadLine().Split(" ");

    string studentName = currentInput[0];
    double studentGrade = double.Parse(currentInput[1]);

    if (studentBook.ContainsKey(studentName))
    {
        studentBook[studentName].Add(studentGrade);
    }
    else
    {
        studentBook.Add(studentName, new List<double>());
        studentBook[studentName].Add(studentGrade);
    }
}

foreach (var kvp in studentBook)
{
    Console.Write($"{kvp.Key} -> {String.Join(" ", kvp.Value)} (avg: {kvp.Value.Average():F2})");
    Console.WriteLine();
}