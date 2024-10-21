using System.Text.Json;

namespace Classes
{
    internal class Storage
    {
        private int capacity;
        private List<Product> storage;
        private double totalCost;

        public int Capacity { get => capacity; }

        public List<Product> Storagee { get => storage; }

        public double TotalCost { get => totalCost; }

        public Storage(int capacity)
        {
            this.capacity = capacity;
            this.storage = new List<Product>();
            totalCost = 0;
        }

        public void AddProduct(Product product)
        {
            if (capacity - product.Quantity < 0)
            {
                Console.WriteLine("Not enough space in the storage for this amount of product.");
            }
            else
            {
                storage.Add(product);
                capacity -= product.Quantity;
                totalCost += product.Quantity * product.Price;
            }
        }

        public string GetProducts()
        {
            string jsonString = JsonSerializer.Serialize(storage);

            return jsonString;
        }
    }
}
