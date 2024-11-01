int[] RowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = RowsAndCols[0];
int cols = RowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(SumMatrixElements(matrix));

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

static int SumMatrixElements(int[,] matrix)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            sum += matrix[row, col];
        }
    }

    return sum;
}