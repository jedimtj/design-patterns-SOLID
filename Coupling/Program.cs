// Coupling - Degree of dependency between different classes

using Coupling;

BadOrder order = new BadOrder();
order.PlaceOrder();

INotificationService emailSender = new GoodEmailSender();
GoodOrder goodOrder = new GoodOrder(emailSender);
goodOrder.PlaceOrder();

INotificationService smsSender = new SmsSender();
GoodOrder goodOrder2 = new GoodOrder(smsSender);
goodOrder2.PlaceOrder();