// where's the dictionary in this problem :?

int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

numbers = numbers.OrderByDescending(x => x).ToArray();

Console.WriteLine(String.Join(", ", numbers.Take(3)));