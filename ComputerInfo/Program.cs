using System;
public class Computer
{
    public string Name { get; set; }
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }

    public Computer(string name, string cpu, int ram, int storage)
    {
        Name = name;
        CPU = cpu;
        RAM = ram;
        Storage = storage;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Computer Name: {Name}");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}GB");
        Console.WriteLine($"Storage: {Storage}GB");
    }
}

public class ComputerInformationSystem
{
    public void GatherInformation(Computer computer)
    {
        Console.WriteLine("Gathering information about the computer...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computer myComputer = new Computer("My PC", "Intel Core i7", 16, 512);
        myComputer.DisplayInfo();

        ComputerInformationSystem informationSystem = new ComputerInformationSystem();
        informationSystem.GatherInformation(myComputer);

        Console.ReadLine();
    }
}
