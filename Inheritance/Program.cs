// Inheritance - Derived class inherits properties and behavior from base class and can also add/override functionality

using Inheritance;

Car car = new Car
{
    Brand = "Toyota",
    Model = "Camry",
    Year = 2020,
    NumberOfSeats = 5,
    NumberOfDoors = 4
};

car.Start();
car.Honk();
car.Stop();