using System;

interface IInternet
{
    void Connect();
}

class RealInternet : IInternet
{
    public void Connect()
    {
        Console.WriteLine("Connected to internet");
    }
}

class InternetProxy : IInternet
{
    private RealInternet internet;

    public InternetProxy()
    {
        internet = new RealInternet();
    }

    public void Connect()
    {
        Console.WriteLine("Checking access...");

        internet.Connect();
    }
}

class Program
{
    static void Main()
    {
        IInternet internet = new InternetProxy();

        internet.Connect();
    }
}