using System;

interface IPayment
{
    void Pay(int amount);
}

class CreditCard : IPayment
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}

class UPI : IPayment
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid " + amount + " using UPI");
    }
}

class PaymentContext
{
    private IPayment payment;

    public PaymentContext(IPayment payment)
    {
        this.payment = payment;
    }

    public void MakePayment(int amount)
    {
        payment.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentContext payment = new PaymentContext(new UPI());

        payment.MakePayment(500);
    }
}