using System;
public class Tortuga: Peces
{
    public string Color { get; set; }

    public void Nada()
    {
        Console.WriteLine("Nadar");
    }

     public void Descripcion() 
    {
        Console.WriteLine("La tortuga pone huevos");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("La tortuga es un animal pequeño");
    }

    private void OtroMetodo()
    {

    }
}