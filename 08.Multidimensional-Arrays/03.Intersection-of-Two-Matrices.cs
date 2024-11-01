int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

string[,] firstMatrix = ReadMatrix(rows, cols);
string[,] secondMatrix = ReadMatrix(rows, cols);

string[,] resultMatrix = new string[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int z = 0; z < cols; z++)
    {
        if (firstMatrix[i, z] == secondMatrix[i, z])
        {
            resultMatrix[i, z] = firstMatrix[i, z];
        }
        else
        {
            resultMatrix[i, z] = "*";
        }
    }
}

PrintMatrix(resultMatrix);

static string[,] ReadMatrix(int rows, int cols)
{
    string[,] matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] rowElements = Console.ReadLine().Split(" ").ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowElements[col];
        }
    }

    return matrix;
}

static void PrintMatrix(string[,] matrix)
{
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}