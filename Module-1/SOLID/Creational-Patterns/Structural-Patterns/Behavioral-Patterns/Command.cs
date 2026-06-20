using System;

interface ICommand
{
    void Execute();
}

class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light turned ON");
    }
}

class LightCommand : ICommand
{
    private Light light;

    public LightCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}

class RemoteControl
{
    private ICommand command;

    public RemoteControl(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        command.Execute();
    }
}

class Program
{
    static void Main()
    {
        Light light = new Light();

        ICommand command = new LightCommand(light);

        RemoteControl remote = new RemoteControl(command);

        remote.PressButton();
    }
}