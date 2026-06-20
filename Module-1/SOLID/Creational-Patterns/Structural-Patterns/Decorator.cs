using System;

interface ICoffee
{
    string GetDescription();

    int GetCost();
}

class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Coffee";
    }

    public int GetCost()
    {
        return 50;
    }
}

class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public string GetDescription()
    {
        return coffee.GetDescription() + " + Milk";
    }

    public int GetCost()
    {
        return coffee.GetCost() + 20;
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee = new SimpleCoffee();

        coffee = new MilkDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());

        Console.WriteLine("Cost: " + coffee.GetCost());
    }
}