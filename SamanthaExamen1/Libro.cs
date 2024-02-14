using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanthaExamen1
{
    internal class Libro
    {
            public string Codigo { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public DateTime FechaPublicacion { get; set; }
            public double Precio { get; set; }
            public bool Disponible { get; set; }

            public Libro(string codigo, string titulo, string autor, DateTime fechaPublicacion, double precio)
            {
                Codigo = codigo;
                Titulo = titulo;
                Autor = autor;
                FechaPublicacion = fechaPublicacion;
                Precio = precio;
                Disponible = true; // por defecto el libro está disponible
            }


            public void Prestar()
            {
                if (Disponible)
                {
                    Disponible = false;
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El libro ha sido prestado.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El libro no está disponible para prestar.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void Devolver()
            {
                if (!Disponible)
                {
                    Disponible = true;
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("El libro ha sido devuelto.");
                    Console.WriteLine("---------------------------------------\n");
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("El libro ya está disponible.");
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void Consultar()
            {
                Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nFecha de Publicación: {FechaPublicacion}\nPrecio: {Precio}\nDisponible: {(Disponible ? "Sí" : "No")}");
            }
        

    }
}
