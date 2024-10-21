using Classes;

Product productOne = new Product("cucumber", 1.50, 15);
Product productTwo = new Product("tomato", 0.90, 25);
Product productThree = new Product("bread", 1.10, 8);

Storage storage = new Storage(50);

storage.AddProduct(productOne);
storage.AddProduct(productTwo);
storage.AddProduct(productThree);

Console.WriteLine(storage.Capacity);
Console.WriteLine(storage.TotalCost);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(storage.GetProducts());