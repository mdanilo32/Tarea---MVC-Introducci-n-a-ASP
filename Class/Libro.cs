using System;

namespace Biblioteca.Clases
{
    class Libro
    {
        // Propiedades básicas del libro
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int? AnioPublicacion { get; set; }
        public string? ISBN { get; set; }

        // Constructor con parámetros opcionales
        public Libro(string titulo, string autor, int? anioPublicacion = null, string? isbn = null)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            ISBN = isbn;
        }

        // Método para obtener la información completa del libro
        public string ObtenerInformacion()
        {
            string anio = AnioPublicacion.HasValue ? AnioPublicacion.ToString() : "Desconocido";
            string isbn = string.IsNullOrEmpty(ISBN) ? "No disponible" : ISBN;

            return $"Título: {Titulo}, Autor: {Autor}, Año: {anio}, ISBN: {isbn}";
        }
    }
}
