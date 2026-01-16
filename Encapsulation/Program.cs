// Encapsulation - Bundling data and methods (operating on that data) within a single unit called a class
// Helps in hiding the internal implementation details by only exposing the necessary parts

using Encapsulation;

BadBankAccount badAccount = new BadBankAccount();
badAccount.Balance = -50;
Console.WriteLine($"Bad Account Balance: {badAccount.Balance}");

GoodBankAccount goodAccount = new GoodBankAccount(100);
Console.WriteLine($"Good Account Initial Balance: {goodAccount.GetBalance()}");
goodAccount.Deposit(50);
Console.WriteLine($"Good Account Balance after Deposit: {goodAccount.GetBalance()}");
goodAccount.Withdraw(30);
Console.WriteLine($"Good Account Balance after Withdrawal: {goodAccount.GetBalance()}");
goodAccount.Withdraw(150);