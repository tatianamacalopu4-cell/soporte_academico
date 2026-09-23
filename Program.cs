using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   SOPORTE ACADÉMICO");
        Console.WriteLine("   Registro de solicitudes");
        Console.WriteLine("========================================");

        Console.Write("Código del estudiante: ");
        string codigo = Console.ReadLine()!;

        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Tipo de consulta: ");
        string tipoConsulta = Console.ReadLine()!;

        Console.Write("Descripción de la solicitud: ");
        string descripcion = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine("Solicitud registrada.");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Consulta: {tipoConsulta}");
        Console.WriteLine($"Descripción: {descripcion}");
    }
}
