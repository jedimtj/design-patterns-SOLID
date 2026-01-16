// Polymorphism - Ability of an object to take on many forms

using Polymorphism;

// Allows us to treat different vehicle types uniformly instead of handling each type separately
List<Vehicle> vehicles =
[
    new Car{Brand = "Toyota", Model = "Camry", Year = 2022, NumberOfSeats = 5, NumberOfDoors = 4},
    new Motorcycle{Brand = "Harley Davidson", Model = "Street 750", Year = 2021},
];

foreach(var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}
