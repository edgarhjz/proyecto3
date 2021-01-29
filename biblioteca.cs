using System;
using System.Collections.Generic;

class Biblioteca
{
    List<Libro> LibrosBiblioteca;
    public Biblioteca() {
       LibrosBiblioteca = new List<Libro>();
    }

    public int NumeroLibros() {
       return LibrosBiblioteca.Count;
    }

    public void AgregarLibro(Libro libro) {
       LibrosBiblioteca.Add(libro);
    }

    public void BorrarLibro(string titulo) {
       bool encontrado = false;
       int posicionABorrar = -1;

       foreach (Libro libro in LibrosBiblioteca) {
          posicionABorrar++;
          if (libro.GetTitulo() == titulo) {
             encontrado = true;
             break;
          }
       }

       if (encontrado) {
          LibrosBiblioteca.RemoveAt(posicionABorrar);
          Console.WriteLine("¡Libro borrado correctamente!");
       }
       else {
          Console.WriteLine("Libro no encontrado");
       }
    }

    public void Mostrar() {
       Console.WriteLine("******* BIBLIOTECA *******");

       foreach (Libro libro in LibrosBiblioteca) {
          libro.Mostrar();
       }

       Console.WriteLine("**************************");
    }
}