namespace Polymorphism;

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle started with a vroom!");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle stopped quickly.");
    }
}
