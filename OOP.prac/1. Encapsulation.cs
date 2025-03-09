namespace OOP.prac;

public class BankAccount(decimal initialBalance = 0)
{
    private decimal _balance = initialBalance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}