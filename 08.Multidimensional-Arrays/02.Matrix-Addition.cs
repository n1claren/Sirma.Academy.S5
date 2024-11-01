int[] dimensions = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

int[,] firstMatrix = ReadMatrix(rows, cols);
int[,] secondMatrix = ReadMatrix(rows, cols);

int[,] resultMatrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int z = 0; z < cols; z++)
    {
        resultMatrix[i, z] = firstMatrix[i, z] + secondMatrix[i, z];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int z = 0; z < cols; z++)
    {
        Console.Write(resultMatrix[i, z] + " ");
    }

    Console.WriteLine();
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