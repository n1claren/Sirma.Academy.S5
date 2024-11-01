int[,] firstMatrix = ReadMatrix();
int[,] secondMatrix = ReadMatrix();

bool areEqual = true;

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(0) ||
    firstMatrix.GetLength(1) != secondMatrix.GetLength(1))
{
    areEqual = false;
}

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    if (!areEqual)
    {
        break;
    }

    for (int z = 0; z < firstMatrix.GetLength(1); z++)
    {
        if (firstMatrix[i, z] != secondMatrix[i, z])
        {
            areEqual = false;
            break;
        }
    }
}

if (areEqual)
{
    Console.WriteLine("equal");
}
else
{
    Console.WriteLine("not equal");
}

static int[,] ReadMatrix()
{
    int[] dimensions = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

    int rows = dimensions[0];
    int cols = dimensions[1];

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