int[] patternA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int[] patternB = { 1, 2, 3, 4, 8, 7, 6, 5, 9, 10, 11, 12, 16, 15, 14, 13 };

string input = Console.ReadLine();

int size = int.Parse(input.Split(" ")[0]);
char pattern = char.Parse(input.Split(" ")[1]);

int[,] matrix = FillMatrix(size, pattern == 'A' ?  patternA : patternB);

PrintMatrix(matrix);

static int[,] FillMatrix(int size, int[] pattern)
{
    int[,] resultMatrix = new int[size, size];

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            resultMatrix[row, col] = pattern[size*col + row];
        }
    }

    return resultMatrix;
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