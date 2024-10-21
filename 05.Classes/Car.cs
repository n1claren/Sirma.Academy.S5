namespace Classes
{
    internal class Car
    {
        private string brand;
        private string model;
        private int horsepower;

        public Car()
        {
            
        }

        public Car(string brand)
        {
            Brand = brand;
            Model = "unknown";
            Horsepower = -1;
        }

        public Car(string brand, string model, int horsepower)
        {
            Brand = brand;
            Model = model;
            Horsepower = horsepower;
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Horsepower
        {
            get
            {
                return horsepower;
            }
            set
            {
                horsepower = value;
            }
        }

        public string carInfo()
        {
            return $"{brand} {model} - {horsepower} HP.";
        }
    }
}