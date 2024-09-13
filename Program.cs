using Biblioteca.Clases;
using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiBiblioteca miBiblioteca = new MiBiblioteca();
            int opcion;

            do
            {
                // Mostrar el menú de opciones
                Console.Clear();
                Console.WriteLine("=== Bienvenido a la Biblioteca Virtual ===");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Buscar Libro por Autor");
                Console.WriteLine("3. Listar Libros");
                Console.WriteLine("4. Eliminar Libro");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                // Validar la entrada del usuario
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro(miBiblioteca);
                            break;
                        case 2:
                            BuscarLibroPorAutor(miBiblioteca);
                            break;
                        case 3:
                            ListarLibros(miBiblioteca);
                            break;
                        case 4:
                            EliminarLibro(miBiblioteca);
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                // Esperar que el usuario presione una tecla antes de continuar
                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }

        // Método para agregar un libro
        static void AgregarLibro(MiBiblioteca miBiblioteca)
        {
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            miBiblioteca.AgregarLibro(titulo, autor);
            Console.WriteLine("Libro agregado exitosamente.");
        }

        // Método para buscar un libro por el autor
        static void BuscarLibroPorAutor(MiBiblioteca miBiblioteca)
        {
            Console.Write("Ingrese el autor a buscar: ");
            string autor = Console.ReadLine();

            miBiblioteca.EncontrarLibrosPorAutor(autor);
        }

        // Método para listar todos los libros en la biblioteca
        static void ListarLibros(MiBiblioteca miBiblioteca)
        {
            miBiblioteca.MostrarLibros();
        }

        // Método para eliminar un libro por su título
        static void EliminarLibro(MiBiblioteca miBiblioteca)
        {
            Console.Write("Ingrese el título del libro a eliminar: ");
            string titulo = Console.ReadLine();

            miBiblioteca.RemoverLibroPorTitulo(titulo);
        }
    }
}
