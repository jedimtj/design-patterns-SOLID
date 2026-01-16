namespace Inheritance;

public class Car : Vehicle
{
    public int NumberOfSeats;
    public int NumberOfDoors; 

    public void Honk()
    {
        Console.WriteLine("Car honked");
    }
}
