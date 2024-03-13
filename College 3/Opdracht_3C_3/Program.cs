namespace Opdracht_3C_2
{
    class Program
    {
        static void Main()
        {
            W_Park Windesheim = new();

            Garage garagePoort = new("Poort");
            Garage garageBuiten = new("Buiten");

            Car myCar = new(Car.Brand.Audi, Car.CarType.Electric, Car.Color.Black, 2021, "Pascal de Wit", "4Y1SL65848Z411439");
            Car yourCar = new(Car.Brand.Toyota, Car.CarType.Diesel, Car.Color.Blue, 2011, "Paul van Breda", "1GNEK13ZX3R298984");

            Windesheim.AddGarage(garagePoort);
            Windesheim.AddGarage(garageBuiten);

            garagePoort.AddCar(myCar);
            garageBuiten.AddCar(yourCar);

            Windesheim.DisplayList();
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

    class Garage(string name)
    {
        public string name { get; } = name;

        readonly List<Car> cars = [];

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public void DisplayCars()
        {
            foreach (Car car in cars)
            {
                car.DisplayInfo();
            }
        }

        public void DisplayGarages()
        {
            Console.WriteLine($"Garage {name}\n");
        }
    }

    class W_Park
    {
        readonly List<Garage> garages = [];

        public void AddGarage(Garage garage)
        {
            garages.Add(garage);
        }

        public void RemoveGarage(Garage garage)
        {
            garages.Remove(garage);
        }

        public void DisplayList()
        {
            foreach (Garage garage in garages)
            {
                garage.DisplayGarages();
                garage.DisplayCars();
            }
        }
    }
}
