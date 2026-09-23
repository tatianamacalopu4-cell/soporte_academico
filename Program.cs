using System;

class Program
{
    static void Main()
    {
        MostrarMenu();

        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine()!;

        if (opcion == "1")
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"===== REGISTRO DE SOLICITUD {i} =====");
                RegistrarSolicitud();
            }

            Console.WriteLine();
            Console.WriteLine("Se registraron las 3 solicitudes correctamente.");
        }
        else if (opcion == "2")
        {
            Console.WriteLine("Programa finalizado.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    // Requerimiento 4: función sin retorno para mostrar el menú
    static void MostrarMenu()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        SOPORTE ACADÉMICO");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Registrar solicitudes");
        Console.WriteLine("2. Salir");
        Console.WriteLine("========================================");
    }

    // Requerimiento 10: permite registrar varias solicitudes
    static void RegistrarSolicitud()
    {
        // Requerimiento 2
        Console.Write("Código del estudiante: ");
        string codigo = Console.ReadLine()!;

        while (!ValidarCodigo(codigo))
        {
            Console.WriteLine("Código inválido. Debe tener al menos 6 caracteres.");
            Console.Write("Ingrese nuevamente el código: ");
            codigo = Console.ReadLine()!;
        }

        // Requerimiento 6
        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine()!;

        while (!ValidarTexto(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            Console.Write("Ingrese nuevamente el nombre: ");
            nombre = Console.ReadLine()!;
        }

        // Requerimiento 3
        Console.Write("Tipo de consulta (matricula, pagos, constancia, plataforma, otro): ");
        string tipoConsulta = Console.ReadLine()!;

        while (!ValidarTipoConsulta(tipoConsulta))
        {
            Console.WriteLine("Tipo de consulta inválido.");
            Console.WriteLine("Opciones: matricula, pagos, constancia, plataforma u otro.");
            Console.Write("Ingrese nuevamente el tipo de consulta: ");
            tipoConsulta = Console.ReadLine()!;
        }

        // Requerimiento 6
        Console.Write("Descripción de la solicitud: ");
        string descripcion = Console.ReadLine()!;

        while (!ValidarTexto(descripcion))
        {
            Console.WriteLine("La descripción no puede estar vacía.");
            Console.Write("Ingrese nuevamente la descripción: ");
            descripcion = Console.ReadLine()!;
        }

        // Requerimiento 5
        string prioridad = CalcularPrioridad(tipoConsulta);

        // Requerimiento 7 y 8
        MostrarResumen(codigo, nombre, tipoConsulta, descripcion, prioridad);
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

    // Requerimiento 5
    static string CalcularPrioridad(string tipoConsulta)
    {
        tipoConsulta = tipoConsulta.ToLower();

        if (tipoConsulta == "matricula" || tipoConsulta == "pagos")
        {
            return "Alta";
        }
        else if (tipoConsulta == "constancia" || tipoConsulta == "plataforma")
        {
            return "Media";
        }
        else
        {
            return "Baja";
        }
    }

    // Requerimiento 6 y 9
    static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto);
    }

    // Requerimiento 7 y 8
    static void MostrarResumen(
        string codigo,
        string nombre,
        string tipoConsulta,
        string descripcion,
        string prioridad)
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       RESUMEN DE LA SOLICITUD");
        Console.WriteLine("========================================");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Consulta: {tipoConsulta}");
        Console.WriteLine($"Descripción: {descripcion}");
        Console.WriteLine($"Prioridad: {prioridad}");
        Console.WriteLine("========================================");
    }
}