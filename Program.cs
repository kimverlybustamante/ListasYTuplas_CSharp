using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione un ejercicio (1 al 5):");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: new Ejercicio1().Ejecutar(); break;
            case 2: new Ejercicio2().Ejecutar(); break;
            case 3: new Ejercicio3().Ejecutar(); break;
            case 4: new Ejercicio4().Ejecutar(); break;
            case 5: new Ejercicio5().Ejecutar(); break;
            default: Console.WriteLine("Opción inválida"); break;
        }

        Console.ReadKey();
    }
}