int[] rowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = rowsAndCols[0];
int cols = rowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

List<int> zeroRows = new List<int>();
List<int> zeroCols = new List<int>();

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (matrix[row, col] == 0)
        {
            if (!zeroCols.Contains(col))
            {
                zeroCols.Add(col);
            }

            if (!zeroRows.Contains(row))
            {
                zeroRows.Add(row);
            }
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (zeroCols.Contains(col) || zeroRows.Contains(row))
        {
            matrix[row, col] = 0;
        }
    }
}

PrintMatrix(matrix);

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

static void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}