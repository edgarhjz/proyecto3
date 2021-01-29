using System;
using System.Collections.Generic;

class Libro
{
    string Titulo;
    string ISBN;
    Autor AutorLibro;

    public Libro(string titulo, string isbn) {
       Titulo = titulo;
       ISBN = isbn;
    }

    public void AgregarAutor(Autor autor) {
       AutorLibro = autor;
    }

    public string GetTitulo() {
       return Titulo;
    }

    public void Mostrar() {
       Console.WriteLine("--- Libro ---");
       Console.WriteLine($"Título: {Titulo}");
       Console.WriteLine($"ISBN: {ISBN}");
       AutorLibro.Mostrar();
       Console.WriteLine("-----------");
    }
}