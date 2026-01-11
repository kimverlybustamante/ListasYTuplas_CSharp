using System;
using System.Collections.Generic;

class Ejercicio4
{
    public void Ejecutar()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese 6 números de la lotería:");
        for (int i = 0; i < 6; i++)
        {
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        numeros.Sort();

        Console.WriteLine("Números ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}