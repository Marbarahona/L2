using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();


            Loro l = new Loro();
            l.Nombre = "Popito";
            l.Patas = 2;
            l.Color = "Verde";
            l.Comer();
            l.Volar();
            l.Hablar();
            l.Descripcion();
            l.Tamano();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje); 
 

            Gallina a = new Gallina();
            a.Nombre = "Colita";
            a.Patas = 2;
            a.Color = "Café";
            a.Comer();
            a.Volar();
            a.Vuelo();
            a.Descripcion();
            a.Tamano();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Tortuga pg = new Tortuga();
            pg.Nombre = "Willy";
            pg.NumeroPatas = 4;
            pg.Color = "Verde";
            pg.Comer();
            pg.Nadar();
            pg.Descripcion();
            pg.Tamano();

            Console.WriteLine(pg.Nombre);
            Console.WriteLine(pg.NumeroPatas);

            Vaca m = new Vaca();
            m.Nombre = "Doly";
            m.Patas = 4;
            m.Habilidad= "Dar leche";
            m.Comer();
            m.Masticar();
            m.Descripcion();
            m.Tamano();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);            

        }
    }
}