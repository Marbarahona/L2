using System;
using System.Collections.Generic;


public class opciones
{
    public List<Cliente> ListadeClientes { get; set; }
    public List<Reservacion> ListadeReservacion { get; set; }
    public List<Habitacion> ListaHabitacion { get; set; }


    public opciones()
    {
        ListadeClientes = new List<Cliente>();
        lcliente();
        ListaHabitacion = new List<Habitacion>();
        listhabitaciones();
        ListadeReservacion = new List<Reservacion>();

    }

    private void lcliente()
    {
        Cliente a1 = new Cliente(001, "Carlos", 25, "M", "Honduras", 88888, "crlos@hotmail.com");
        ListadeClientes.Add(a1);
        Cliente a2 = new Cliente(002, "Christopher", 20, "M", "Mexico", 99999, "chris@hotmail.com");
        ListadeClientes.Add(a2);
        Cliente a3 = new Cliente(003, "Jennifer", 27, "F", "España", 2222, "jenn55s@hotmail.com");
        ListadeClientes.Add(a3);
        Cliente a4 = new Cliente(004, "Ludmila", 26, "F", "Italia", 33333, "ludmi56s@hotmail.com");
        ListadeClientes.Add(a4);
        Cliente a5 = new Cliente(005, "Caled", 35, "M", "Panama", 55555, "caleds@hotmail.com");
        ListadeClientes.Add(a5);
        Cliente a6 = new Cliente(006, "Victoria", 55, "F", "Costa Rica", 44444, "vic44@hotmail.com");
        ListadeClientes.Add(a6);
    }

    private void listhabitaciones()
    {
        Habitacion b1 = new Habitacion(1, "Primera clase", 2, 4, 5000);
        ListaHabitacion.Add(b1);
        Habitacion b2 = new Habitacion(2, "Segunda Clase", 2, 5, 3000);
        ListaHabitacion.Add(b2);
        Habitacion b3 = new Habitacion(3, "Tercera Clase", 1, 8, 1000);
        ListaHabitacion.Add(b3);
    }

    public void listaclientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.id + " | " + cliente.Nombre + " | " + cliente.Edad + " | " + cliente.LugarOrigen + " | " + cliente.Correo);
        }
        Console.ReadLine();
    }
    
    public void listahabitaciones()
    {
        Console.Clear();
        Console.WriteLine("Lista de Habitaciones disponibles");
        Console.WriteLine("=================================");
        Console.WriteLine("Codigo | Tipo de Habitacion | Numero de Camas | Disponibles | Precio");
        Console.WriteLine("");

        foreach (var habitacion in ListaHabitacion)
        {
            Console.WriteLine(habitacion.Codigo + " | " + habitacion.TipoHabitacion + " | " + habitacion.NCamas + " | " + habitacion.Cantidad + " | " + habitacion.Precio);
            
        }
        
        Console.ReadLine();

    }

    public void CrearReservacion()
    {
        Console.WriteLine("Nueva Reservacion");
        Console.WriteLine("=================");
        Console.WriteLine("");

        Console.WriteLine("Por favor ingrese el codigo del cliente: ");
        string codcliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.id.ToString() == codcliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        int newcodigo = ListadeReservacion.Count +1;

        Reservacion nuevareservacion = new Reservacion(newcodigo, DateTime.Now, "HN", cliente);
        ListadeReservacion.Add(nuevareservacion);

        while (true)
        {
            Console.WriteLine("Ingrese el codigo de la habitacion");
            string codigohabitacion = Console.ReadLine();
            Habitacion habitacion1 = ListaHabitacion.Find(h => h.Codigo.ToString() == codigohabitacion);

            if (habitacion1 == null)
            {
                Console.WriteLine("LA HABITACION NO SE HA ENCONTRADO");
                Console.ReadLine();
            } 
            else {
                Console.WriteLine("Habitacion Agregada: " + habitacion1.TipoHabitacion + " con precio de: " + habitacion1.Precio);
                nuevareservacion.AgregarReservacion(habitacion1);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

            Console.WriteLine("");
            Console.WriteLine("El Subtotal de la reservacion es: " + nuevareservacion.Subtotal);
            Console.WriteLine("El Subtotal con impuesto es : " + nuevareservacion.Impuesto);
            Console.WriteLine("Total de la reservacion es de: " + nuevareservacion.Total);
            Console.ReadLine();
    }

    public void ListaReservaciones()
    {
        Console.Clear();
        Console.WriteLine("Lista de Reservaciones");
        Console.WriteLine("======================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | Subtotal | Impuesto | Total");
        Console.WriteLine("Cliente");
        Console.WriteLine("=======================");
        Console.WriteLine(""); 

        foreach (var reserva in ListadeReservacion)
        {
            Console.WriteLine(reserva.CodigoReservacion + " | " + reserva.Fecha + " | " + reserva.Subtotal + " | " + reserva.Impuesto + " | " + reserva.Total);
            Console.WriteLine(reserva.Cliente.Nombre);
        }

        Console.ReadLine();
    }
}