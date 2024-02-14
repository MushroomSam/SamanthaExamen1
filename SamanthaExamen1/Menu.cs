
using System;
using System.Collections.Generic;
using System.Linq;
using SamanthaExamen1;


public interface ILibro
{
    void Prestar();
    void Devolver();
    void Consultar();
}

class Menu
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar un libro a la biblioteca.");
            Console.WriteLine("2. Eliminar un libro de la biblioteca.");
            Console.WriteLine("3. Mostrar todos los libros de la biblioteca.");
            Console.WriteLine("4. Buscar libros por inicio del nombre del autor.");
            Console.WriteLine("5. Mostrar libro de mayor precio.");
            Console.WriteLine("6. Mostrar los tres libros más baratos.");
            Console.WriteLine("7. Salir del programa.");
            Console.WriteLine("Seleccione una opción: ");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------\n");
            

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                Console.WriteLine("---------------------------------------\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese los datos del libro:");
                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Fecha de Publicación (dd/mm/yyyy): ");
                    DateTime fechaPublicacion;
                    if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaPublicacion))
                    {
                        Console.WriteLine("Formato de fecha incorrecto. Intente de nuevo.");
                        continue;
                    }
                    Console.Write("Precio: ");
                    double precio;
                    if (!double.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Precio inválido. Intente de nuevo.\n");
                        Console.ResetColor();
                        continue;
                    }
                    biblioteca.AgregarLibro(new Libro(codigo, titulo, autor, fechaPublicacion, precio));
                    break;
                case 2:
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingrese el código del libro a eliminar. ");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                    string codigoEliminar = Console.ReadLine();
                    biblioteca.EliminarLibro(codigoEliminar);
                    break;
                case 3:
                    biblioteca.MostrarLibros();
                    break;
                case 4:
                    Console.WriteLine("Ingrese el inicio del nombre del autor. \n");
                    string inicioNombreAutor = Console.ReadLine();
                    biblioteca.BuscarLibrosPorAutor(inicioNombreAutor);
                    break;
                case 5:
                    biblioteca.MostrarLibroMayorPrecio();
                    break;
                case 6:
                    biblioteca.MostrarTresLibrosMasBaratos();
                    break;
                case 7:
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Hasta luego!");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------------\n");
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
