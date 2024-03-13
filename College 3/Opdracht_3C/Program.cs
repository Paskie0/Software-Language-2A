namespace Opdracht_3C
{
    class Program
    {
        static void Main()
        {
            Car myCar = new(Car.Brand.Audi, Car.CarType.Electric, Car.Color.Black, 2021, "Pascal de Wit", "4Y1SL65848Z411439");
            Car yourCar = new(Car.Brand.Toyota, Car.CarType.Diesel, Car.Color.Blue, 2011, "Paul van Breda", "1GNEK13ZX3R298984");

            myCar.DisplayInfo();
            yourCar.DisplayInfo();
        }
    }

    class Car(Car.Brand brand, Car.CarType type, Car.Color color, int year, string owner, string VIN)
    {
        public enum Brand { Audi, BMW, Toyota }
        public enum CarType { Diesel, Petrol, Electric }
        public enum Color { Red, Black, Blue }

        public Brand brand { get; } = brand;
        public CarType type { get; } = type;
        public Color color { get; } = color;
        public int year { get; } = year;
        public string owner { get; } = owner;
        public string VIN { get; } = VIN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"VIN: {VIN}");
            Console.WriteLine();
        }
    }
}
