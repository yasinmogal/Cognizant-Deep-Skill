using System;

class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating total");
    }
}

class InvoicePrinter
{
    public void PrintInvoice()
    {
        Console.WriteLine("Printing invoice");
    }
}

class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice();
        InvoicePrinter printer = new InvoicePrinter();

        invoice.CalculateTotal();
        printer.PrintInvoice();
    }
}