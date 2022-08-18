using System;
using System.Collections.Generic;

public class Reservacion
{
    public int CodigoReservacion { get; set; }
    public DateTime Fecha { get; set; }
    public string NReservacion { get; set; }
    public Cliente Cliente { get; set; }
    public List<DesReservacion> ListadeReservacion { get; set; }
     public double Subtotal { get; set; }
    public double Impuesto { get; set; }

    public double Total { get; set; }

    public Reservacion(int codigoreservacion, DateTime fecha, string nreservacion, Cliente cliente)
    {
        CodigoReservacion = codigoreservacion;
        Fecha = fecha;
        NReservacion = nreservacion;
        Cliente = cliente;
        ListadeReservacion = new List<DesReservacion>();
        
    }

    public void AgregarReservacion(Habitacion habitacion)
    {
        int ncodigo = ListadeReservacion.Count +1;
        int cantidad = 1;

        DesReservacion o = new DesReservacion(ncodigo, 1, habitacion);
        ListadeReservacion.Add(o);

        Subtotal += cantidad * habitacion.Precio;
        Impuesto += Subtotal * 0.15;
        Total += Subtotal + Impuesto;
    }
}