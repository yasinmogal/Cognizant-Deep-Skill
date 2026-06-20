using System;

class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("Bird is moving");
    }
}

class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

class Program
{
    static void Main()
    {
        Bird bird = new Sparrow();

        bird.Move();
    }
}