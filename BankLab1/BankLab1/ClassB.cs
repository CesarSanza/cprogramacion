namespace BankLab1;

public class ClassB
{
    public string holder;
    public float balance;

    public ClassB(string holder, float balance)
    {
        this.holder = holder;
        this.balance = balance;
    }

    public string ShowBalance()
    {
        return $"El saldo es de {balance}";
    }

    public void Deposit(float amount)
    {
        balance = balance + amount;
        Console.WriteLine($"Se depositaron {amount}");
    }

    public float Withdraw(float amount)
    {
        if (amount > balance)
        {
            Console.WriteLine($"No es posible retirar {amount} ya que es mayor a los {balance} que se tienen");
            return 0;
        }
        balance = balance - amount;
        Console.WriteLine($"Se retiraron {amount}");
        return amount;
    }
}