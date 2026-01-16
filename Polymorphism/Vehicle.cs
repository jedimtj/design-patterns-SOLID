namespace Polymorphism;

public class Vehicle
{
    public required string Brand;
    public required string Model;
    public int Year;

    // Making methods virtual to allow overriding in derived classes
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}

