class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota");
        Car car2 = new Car("Honda");

        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);

        Washer washer = new Washer();
        Wash deleg = Washer.Wash;

        garage.WashAllCars(deleg);
    }
}
delegate void Wash(Car car);

class Car
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }
}

class Garage
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void WashAllCars(Wash del)
    {
        foreach (var car in cars)
        {
            del(car);
        }
    }
}

class Washer
{
    public static void Wash(Car car)
    {
        Console.WriteLine($"Washing {car.Model}...");
    }
}

