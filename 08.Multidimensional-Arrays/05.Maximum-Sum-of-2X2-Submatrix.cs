int[] RowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = RowsAndCols[0];
int cols = RowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

int biggestSum = 0;
int biggestSumRow = 0;
int biggestSumCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        if (matrix[row, col] + 
            matrix[row + 1, col] + 
            matrix[row, col + 1] + 
            matrix[row + 1, col + 1] > biggestSum)
        {
            biggestSum = matrix[row, col] + 
                         matrix[row + 1, col] + 
                         matrix[row, col + 1] + 
                         matrix[row + 1, col + 1];

            biggestSumRow = row;
            biggestSumCol = col;
        }
    }
}

Console.WriteLine(biggestSum);
Console.WriteLine();
Console.WriteLine($"{matrix[biggestSumRow, biggestSumCol]} {matrix[biggestSumRow, biggestSumCol + 1]}");
Console.WriteLine($"{matrix[biggestSumRow + 1, biggestSumCol]} {matrix[biggestSumRow + 1, biggestSumCol + 1]}");

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] rowElements = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowElements[col];
        }
    }

    return matrix;
}