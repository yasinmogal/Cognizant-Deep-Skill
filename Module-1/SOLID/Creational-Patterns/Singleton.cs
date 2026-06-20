using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Singleton object created");
    }
}

class Program
{
    static void Main()
    {
        Singleton obj1 = Singleton.GetInstance();

        obj1.ShowMessage();
    }
}