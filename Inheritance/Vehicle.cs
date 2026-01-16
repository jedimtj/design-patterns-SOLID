namespace Inheritance;

public class Vehicle
{
    public required string Brand;
    public required string Model;
    public int Year;

    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}
