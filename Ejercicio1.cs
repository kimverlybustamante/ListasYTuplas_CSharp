using System;
using System.Collections.Generic;

class Ejercicio1
{
    public void Ejecutar()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        Console.WriteLine("Asignaturas del curso:");
        foreach (string a in asignaturas)
        {
            Console.WriteLine(a);
        }
    }
}