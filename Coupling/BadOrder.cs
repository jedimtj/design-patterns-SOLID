namespace Coupling;

// Tightly coupled with BadEmailSender
public class BadOrder
{
    public void PlaceOrder()
    {
        // Order placing logic
        BadEmailSender emailSender = new BadEmailSender();
        emailSender.SendEmail("Order placed successfully.");
    }
}
