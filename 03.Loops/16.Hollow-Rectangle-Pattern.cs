int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
	for (int z = 1; z <= columns; z++)
	{
		if (i == 1 || i == rows)
		{
			Console.Write("*");
		}
		else if (z == 1 || z == columns)
		{
			Console.Write("*");
		}
        else
        {
			Console.Write(" ");
        }
    }

    Console.WriteLine();
}