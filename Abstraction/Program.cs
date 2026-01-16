// Abstraction - Reducing complexity by hiding unnecessary implementation details

using Abstraction;

// Clients have the responsibility to execute workflow correctly and keep track of any internal changes
BadEmailService badEmailService = new BadEmailService();
badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail();
badEmailService.Disconnect();

GoodEmailService goodEmailService = new GoodEmailService();
goodEmailService.SendEmail();