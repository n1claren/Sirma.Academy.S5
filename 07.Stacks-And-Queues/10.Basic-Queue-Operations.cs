int[] NSX = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int elementsToEnque = NSX[0];
int elementsToDeque = NSX[1];
int elementToSearch = NSX[2];

int[] input = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Queue<int> queue = new Queue<int>();

for (int i = 0; i < elementsToEnque; i++)
{
    queue.Enqueue(input[i]);
}

for (int i = 0; i < elementsToDeque; i++)
{
    queue.Dequeue();
}

if (queue.Contains(elementToSearch))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}