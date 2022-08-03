using System;
public class Vaca: Mamifero
{
    public string Habilidad{ get; set; }

    public void Masticar()
    {
        Console.WriteLine("COme césped");
    }

    public void Descripcion() 
    {
        Console.WriteLine("La vaca da leche");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("La vaca es un animal grnade y pesado");
    }

    private void OtroMetodo()
    {

    }
}