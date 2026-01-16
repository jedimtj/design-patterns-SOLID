namespace Encapsulation;

public class GoodBankAccount
{
    private decimal Balance = 0;

    public GoodBankAccount(decimal initialDeposit)
    {
        this.Deposit(initialDeposit);
    }

    public decimal GetBalance()
    {
        return this.Balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        this.Balance += amount;
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > this.Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        this.Balance -= amount;
    }
    
}
