using System;
public class Loro: Aves
{
    public string Color { get; set; }

    public void Hablar()
    {
        Console.WriteLine("Paquito, paquito");
    }

     public void Descripcion() 
    {
        Console.WriteLine("El loro es un animal doméstico");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El loro es un animal mediano");
    }

    private void OtroMetodo()
    {

    }
}