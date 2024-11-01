int[] rowsAndCols = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = rowsAndCols[0];
int cols = rowsAndCols[1];

int[,] matrix = ReadMatrix(rows, cols);

bool threat = false;

for (int row = 0; row < rows; row++)
{
    if (threat)
    {
        break;
    }

    for (int col = 0; col < cols; col++)
    {
        if (matrix[row, col] == 1)
        {
            if (CheckRow(matrix, row, col) ||
                CheckColumn(matrix, row, col) ||
                CheckDiagonal(matrix, row, col))
            {
                threat = true;
                break;
            }
        }
    }
}

if (threat)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

static bool CheckRow(int[,] matrix, int row, int col)
{
    int queen = matrix[row, col];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        if (i != col && matrix[row, i] == queen)
        {
            return true;
        }
    }

    return false;
}

static bool CheckColumn(int[,] matrix, int row, int col)
{
    int queen = matrix[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != row && matrix[i, col] == queen)
        {
            return true;
        }
    }

    return false;
}

// ChatGPT generated method
static bool CheckDiagonal(int[,] matrix, int row, int col)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int value = matrix[row, col];

    int startRow = row - Math.Min(row, col);
    int startCol = col - Math.Min(row, col);

    while (startRow < n && startCol < m)
    {
        if (startRow != row && startCol != col && matrix[startRow, startCol] == value)
        {
            return true;
        }

        startRow++;
        startCol++;
    }

    startRow = row - Math.Min(row, m - 1 - col);
    startCol = col + Math.Min(row, m - 1 - col);

    while (startRow < n && startCol >= 0)
    {
        if (startRow != row && startCol != col && matrix[startRow, startCol] == value)
        {
            return true;
        }

        startRow++;
        startCol--;
    }

    return false;
}

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