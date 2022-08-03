using System;

public abstract class Peces: Animal
{
    public int NumeroPatas { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }
}