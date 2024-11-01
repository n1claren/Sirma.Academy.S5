int rowsAndCols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rowsAndCols, rowsAndCols];

for (int row = 0; row < rowsAndCols; row++)
{
    int[] rowElements = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

    for (int col = 0; col < rowsAndCols; col++)
    {
        matrix[row, col] = rowElements[col];
    }
}

for (int i = 0; i < rowsAndCols; i++)
{
    Console.Write(matrix[i, i] + " ");
}

Console.WriteLine();

for (int i = 0; i < rowsAndCols; i++)
{
    Console.Write(matrix[rowsAndCols - i - 1, i] + " ");
}