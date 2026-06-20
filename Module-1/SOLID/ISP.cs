using System;

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }
}

class MultiFunctionPrinter : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document");
    }
}

class Program
{
    static void Main()
    {
        Printer p = new Printer();

        p.Print();

        MultiFunctionPrinter mfp = new MultiFunctionPrinter();

        mfp.Print();

        mfp.Scan();
    }
}