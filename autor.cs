using System;
using System.Collections.Generic;

class Autor
{
    string Nombre;
    string Apellidos;

    public Autor(string nombre, string apellidos) {
       Nombre = nombre;
       Apellidos = apellidos;
    }

    public void Mostrar() {
       Console.WriteLine($"Autor: {Nombre}, {Apellidos}");
    }
}