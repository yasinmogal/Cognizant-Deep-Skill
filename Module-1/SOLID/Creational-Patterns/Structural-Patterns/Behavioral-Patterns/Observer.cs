using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string message);
}

class Subscriber : IObserver
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(name + " received: " + message);
    }
}

class YouTubeChannel
{
    private List<IObserver> subscribers = new List<IObserver>();

    public void Subscribe(IObserver observer)
    {
        subscribers.Add(observer);
    }

    public void Notify(string message)
    {
        foreach (IObserver subscriber in subscribers)
        {
            subscriber.Update(message);
        }
    }
}

class Program
{
    static void Main()
    {
        YouTubeChannel channel = new YouTubeChannel();

        channel.Subscribe(new Subscriber("Yasin"));

        channel.Subscribe(new Subscriber("Alex"));

        channel.Notify("New video uploaded");
    }
}