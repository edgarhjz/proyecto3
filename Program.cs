using System;

namespace proyecto3
{
    class Program
    {
        static void MostrarMenu() {
            Console.WriteLine("* Menú *");
            Console.WriteLine("1. Agregar libro a la biblioteca");
            Console.WriteLine("2. Mostrar biblioteca");
            Console.WriteLine("3. Borar libro");
            Console.WriteLine("4. ¿Número de libros?");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
        }

        static Biblioteca AgregarLibroALaBiblioteca(Biblioteca biblioteca) {
            string titulo, isbn, autornombre, autorapellidos;
            Console.Write("Ingrese el título del libro: ");
            titulo = Console.ReadLine();
            Console.Write("Ingrese el ISBN del libro: ");
            isbn = Console.ReadLine();
            Console.Write("Ingrese el nombre del autor del libro: ");
            autornombre = Console.ReadLine();
            Console.Write("Ingrese los apellidos del autor del libro: ");
            autorapellidos = Console.ReadLine();

            Autor autor = new Autor(autornombre, autorapellidos);
            Libro libro = new Libro(titulo, isbn);
            libro.AgregarAutor(autor);
            biblioteca.AgregarLibro(libro);
            return biblioteca;
        }

        static Biblioteca BorrarLibroDeLaBiblioteca(Biblioteca biblioteca) {
            Console.Write("Ingrese el título del libro a borrar: ");
            biblioteca.BorrarLibro(Console.ReadLine());
            return biblioteca;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
