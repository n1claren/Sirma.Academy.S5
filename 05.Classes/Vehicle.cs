namespace Classes
{
    internal class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Fuel { get; set; }

        public Vehicle(string type, string model, Engine engine, int fuel)
        {
            Type = type;
            Model = model;
            Engine = engine;
            Fuel = fuel;
        }

        public void Drive(int fuel)
        {
            if (fuel > Fuel)
            {
                Console.WriteLine("Not enough fuel for this drive.");
            }
            else
            {
                Fuel -= fuel;
            }
        }
    }
}
