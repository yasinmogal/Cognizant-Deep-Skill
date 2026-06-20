using System;

class OldPrinter
{
    public void OldPrint()
    {
        Console.WriteLine("Printing using old printer");
    }
}

interface IPrinter
{
    void Print();
}

class PrinterAdapter : IPrinter
{
    private OldPrinter oldPrinter;

    public PrinterAdapter()
    {
        oldPrinter = new OldPrinter();
    }

    public void Print()
    {
        oldPrinter.OldPrint();
    }
}

class Program
{
    static void Main()
    {
        IPrinter printer = new PrinterAdapter();

        printer.Print();
    }
}