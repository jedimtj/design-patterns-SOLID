namespace Polymorphism;

public class Car : Vehicle
{
    public int NumberOfSeats;
    public int NumberOfDoors; 

    public void Honk()
    {
        Console.WriteLine("Car honked");
    }

    public override void Start()
    {
        Console.WriteLine("Car started with a roar!");
    }

    public override void Stop()
    {
        Console.WriteLine("Car stopped smoothly.");
    }
}
