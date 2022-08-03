using System;

public abstract class Aves: Animal
{
    public int ColorPlumaje { get; set; }
    public int Patas { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando...");
    }
}