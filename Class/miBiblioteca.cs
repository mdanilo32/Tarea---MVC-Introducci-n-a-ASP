using System;
using System.Collections.Generic;

namespace Biblioteca.Clases
{
    class MiBiblioteca
    {
        // Lista interna que almacena los libros
        private List<Libro> libros;

        public MiBiblioteca()
        {
            libros = new List<Libro>();
        }

        // Método para agregar un libro usando la clase Libro
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine($"El libro '{libro.Titulo}' ha sido añadido a la colección.");
        }

        // Sobrecarga para agregar un libro solo con título y autor
        public void AgregarLibro(string titulo, string autor)
        {
            libros.Add(new Libro(titulo, autor));
            Console.WriteLine($"Se añadió '{titulo}' de {autor} a la biblioteca.");
        }

        // Mostrar todos los libros disponibles
        public void MostrarLibros()
        {
            Console.WriteLine("Lista de libros en la biblioteca:");
            if (libros.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía.");
                return;
            }

            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ObtenerInformacion());
            }
        }

        // Método para eliminar un libro por su título
        public void RemoverLibroPorTitulo(string titulo)
        {
            var libro = libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine($"Se ha removido el libro: '{titulo}'.");
            }
            else
            {
                Console.WriteLine($"No se encontró un libro titulado '{titulo}'.");
            }
        }

        // Método para buscar libros por autor
        public void EncontrarLibrosPorAutor(string autor)
        {
            var librosDelAutor = libros.FindAll(l => l.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
            if (librosDelAutor.Count > 0)
            {
                Console.WriteLine($"Libros encontrados del autor '{autor}':");
                foreach (var libro in librosDelAutor)
                {
                    Console.WriteLine(libro.ObtenerInformacion());
                }
            }
            else
            {
                Console.WriteLine($"No hay libros del autor '{autor}' en la biblioteca.");
            }
        }
    }
}
