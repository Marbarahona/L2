public class DesReservacion
{
    public int Codigo { get; set; }
    public int NumeroPersonas { get; set; }
    public double Precio { get; set; }
    public Habitacion Habitacion { get; set; }

    public DesReservacion(int codigo, int numeropersonas, Habitacion habitacion)
    {
        Codigo = codigo;
        NumeroPersonas = numeropersonas;
        Habitacion = habitacion;
        Precio = habitacion.Precio;

    }
}