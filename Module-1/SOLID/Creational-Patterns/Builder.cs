using System;

class Computer
{
    public string CPU;
    public string RAM;
    public string Storage;

    public void Show()
    {
        Console.WriteLine("CPU: " + CPU);

        Console.WriteLine("RAM: " + RAM);

        Console.WriteLine("Storage: " + Storage);
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;

        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        computer.RAM = ram;

        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        computer.Storage = storage;

        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        Computer pc = new ComputerBuilder()

            .SetCPU("Intel i5")

            .SetRAM("16 GB")

            .SetStorage("512 GB SSD")

            .Build();

        pc.Show();
    }
}