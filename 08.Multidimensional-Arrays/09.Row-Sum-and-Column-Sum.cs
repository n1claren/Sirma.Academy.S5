int[] rowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = rowsAndCols[0];
int cols = rowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

int[] rowSum = new int[rows];
int[] colSum = new int[cols];

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        rowSum[row] += matrix[row, col];
        colSum[col] += matrix[row, col];
    }
}

Console.WriteLine($"Row Sums: {String.Join(", ", rowSum)}");
Console.WriteLine($"Column Sums: {String.Join(", ", colSum)}");

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