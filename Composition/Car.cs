namespace Composition;

public class Car
{
    private Chassis _chassis = new Chassis();
    private Engine _engine= new Engine();
    private Wheels _wheels = new Wheels();
    private Seats _seats = new Seats();

    public void StartCar()
    {
        _engine.Start();
        _wheels.Rotate();
        _chassis.Support();
        _seats.Sit();
        Console.WriteLine("Car started.");
    }
}
