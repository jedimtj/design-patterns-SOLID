namespace Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        // SMS sending logic
        Console.WriteLine("Sending SMS: " + message);
    }
}
