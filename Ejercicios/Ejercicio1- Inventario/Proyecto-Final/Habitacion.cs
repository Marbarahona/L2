public class Habitacion
{
    public int Codigo { get; set; }
    public string TipoHabitacion { get; set; }
    public int NCamas { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    public Habitacion(int codigo, string tipohabitacio, int ncamas, int cantidad, double precio)
    {
        Codigo = codigo;
        TipoHabitacion = tipohabitacio;
        NCamas = ncamas;
        Cantidad = cantidad;
        Precio = precio;
    }
}