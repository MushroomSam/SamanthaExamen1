using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanthaExamen1
{
    internal class Biblioteca
    {
            private List<Libro> libros;

            public Biblioteca()
            {
                libros = new List<Libro>();
            }

            public void AgregarLibro(Libro libro)
            {
                libros.Add(libro);
                Console.WriteLine("---------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El libro a sido agregado a la biblioteca.");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------\n");
            }

            public void EliminarLibro(string codigo)
            {
                Libro libro = libros.FirstOrDefault(l => l.Codigo == codigo);
                if (libro != null)
                {
                    libros.Remove(libro);
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Libro eliminado de la biblioteca.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("El libro no se encuentra en la biblioteca.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void MostrarLibros()
            {
                if (libros.Count > 0)
                {
                    foreach (var libro in libros)
                    {
                        libro.Consultar();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("La biblioteca está vacía.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void BuscarLibrosPorAutor(string nombreAutor)
            {
                var librosEncontrados = libros.Where(l => l.Autor.StartsWith(nombreAutor, StringComparison.InvariantCultureIgnoreCase));
                if (librosEncontrados.Any())
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Libro encontrado.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                    foreach (var libro in librosEncontrados)
                    {
                        libro.Consultar();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("No se encontraron libros con ese nombre.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void MostrarLibroMayorPrecio()
            {
                var libroMayorPrecio = libros.OrderByDescending(l => l.Precio).FirstOrDefault();
                if (libroMayorPrecio != null)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Libro con mayor precio");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                    libroMayorPrecio.Consultar();
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay libros.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }

            public void MostrarTresLibrosMasBaratos()
            {
                var librosMasBaratos = libros.OrderBy(l => l.Precio).Take(3);
                if (librosMasBaratos.Any())
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tres libros más baratos:");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                    foreach (var libro in librosMasBaratos)
                    {
                        libro.Consultar();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay libros.");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                }
            }
    }
    
}
