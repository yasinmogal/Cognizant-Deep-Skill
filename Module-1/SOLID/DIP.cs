using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email sent");
    }
}

class Notification
{
    private IMessage message;

    public Notification(IMessage message)
    {
        this.message = message;
    }

    public void NotifyUser()
    {
        message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage email = new Email();

        Notification notification = new Notification(email);

        notification.NotifyUser();
    }
}