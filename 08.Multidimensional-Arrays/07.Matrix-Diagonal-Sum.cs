int[] RowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = RowsAndCols[0];
int cols = RowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

if (rows != cols)
{
    Console.WriteLine("The matrix is not square so there are no diagonals...");
    Environment.Exit(0);
}

int sum = 0;

for (int i = 0; i < rows; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    sum += matrix[rows - i - 1, i];
}

Console.WriteLine(sum);

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