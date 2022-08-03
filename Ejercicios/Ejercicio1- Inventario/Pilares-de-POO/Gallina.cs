using System;
public class Gallina: Aves
{
    public string Color { get; set; }

    public void Vuelo()
    {
        Console.WriteLine("Corre rápido");
    }

      public void Descripcion() 
    {
        Console.WriteLine("La gallina tiene plumas y pone huevos");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("La gallina es un animal pequeño");
    }

    private void OtroMetodo()
    {

    }
}