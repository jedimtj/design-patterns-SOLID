namespace Coupling;

// Loosely coupled using INotificationService
// Allows for different notification services to be used interchangeably
public class GoodOrder
{
    private readonly INotificationService _notificationService;

    public GoodOrder(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        // Order placing logic
        _notificationService.SendNotification("Order placed successfully.");
    }
    
}
