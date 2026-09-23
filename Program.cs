using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        SOPORTE ACADÉMICO");
        Console.WriteLine("   Registro de solicitudes");
        Console.WriteLine("========================================");

        Console.Write("Código del estudiante: ");
        string codigo = Console.ReadLine()!;

        while (!ValidarCodigo(codigo))
        {
            Console.WriteLine("Código inválido. Debe tener al menos 6 caracteres.");
            Console.Write("Ingrese nuevamente el código: ");
            codigo = Console.ReadLine()!;
        }

        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Tipo de consulta (matricula, pagos, constancia, plataforma, otro): ");
        string tipoConsulta = Console.ReadLine()!;

        while (!ValidarTipoConsulta(tipoConsulta))
        {
            Console.WriteLine("Tipo de consulta inválido.");
            Console.WriteLine("Opciones: matricula, pagos, constancia, plataforma u otro.");
            Console.Write("Ingrese nuevamente el tipo de consulta: ");
            tipoConsulta = Console.ReadLine()!;
        }

        Console.Write("Descripción de la solicitud: ");
        string descripcion = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine("Solicitud registrada.");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Consulta: {tipoConsulta}");
        Console.WriteLine($"Descripción: {descripcion}");
    }

    // Requerimiento 2
    static bool ValidarCodigo(string codigo)
    {
        return !string.IsNullOrWhiteSpace(codigo) && codigo.Length >= 6;
    }

    // Requerimiento 3
    static bool ValidarTipoConsulta(string tipoConsulta)
    {
        tipoConsulta = tipoConsulta.ToLower();

        return tipoConsulta == "matricula" ||
               tipoConsulta == "pagos" ||
               tipoConsulta == "constancia" ||
               tipoConsulta == "plataforma" ||
               tipoConsulta == "otro";
    }
}