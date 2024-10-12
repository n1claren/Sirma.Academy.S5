string[] array = Console.ReadLine().Split(',');

int rotations = int.Parse(Console.ReadLine());

int arrayLength = array.Length;

for (int i = 0; i < rotations; i++)
{
    string lastElement = array[arrayLength - 1];

    for (int z = arrayLength - 1; z > 0; z--)
    {
        array[z] = array[z - 1];
    }

    array[0] = lastElement;
}

Console.WriteLine(string.Join(" ", array));