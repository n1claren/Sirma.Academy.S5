using Generics;

Jar<int> intJar = new Jar<int>();
intJar.Add(10);
intJar.Add(20);
Console.WriteLine(intJar.Remove());
Console.WriteLine(intJar.Remove());

Jar<string> stringJar = new Jar<string>();
stringJar.Add("Apple");
stringJar.Add("Banana");
Console.WriteLine(stringJar.Remove());
Console.WriteLine(stringJar.Remove());

int[] intArray = ArrayCreator.Create(5, 42);
Console.WriteLine(string.Join(", ", intArray));

string[] stringArray = ArrayCreator.Create(typeof(string), 3, "Hello");
Console.WriteLine(string.Join(", ", stringArray));

// string[] wrongStringArray = ArrayCreator.Create(typeof(double), 3, "Hello");
// Console.WriteLine(string.Join(", ", stringArray));

Scale<int> intScale = new Scale<int>(10, 20);
Console.WriteLine(intScale.GetHeavier());

Scale<string> stringScale = new Scale<string>("Apple", "Banana");
Console.WriteLine(stringScale.GetHeavier());

Scale<int> equalScale = new Scale<int>(15, 15);
Console.WriteLine(equalScale.GetHeavier() == null ? "Equal" : equalScale.GetHeavier().ToString());