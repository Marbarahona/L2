using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            opciones nopcion = new opciones();
            string opcion ="";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("********Bienvenido al Sistema de Reservacion Hera********");
                Console.WriteLine("");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("");
                Console.WriteLine(" 1. --Nuevo Reservacion");
                Console.WriteLine(" 2. --Lista de Clientes");
                Console.WriteLine(" 3. --Lista de Habitaciones disponibles");
                Console.WriteLine(" 4. --Lista de Reservaciones");
                Console.WriteLine(" 5. --Salir");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                    nopcion.CrearReservacion();
                    break;
                    case "2":
                    nopcion.listaclientes();
                    break;
                    case "3":
                    nopcion.listahabitaciones();
                    break;
                    case "4":
                    nopcion.ListaReservaciones();
                    break;                    
                default:
                    break;
                }
                 if(opcion=="5")
                 {
                     break;
                 }
            }

        }
    }
}