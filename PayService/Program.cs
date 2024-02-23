using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica): ");
        string tipoServicio = Console.ReadLine().ToLower(); // Convertir a minúsculas para manejar entradas mixtas

        double importePagar = CalcularImporte(tipoServicio);

        if (importePagar != -1)
        {
            Console.WriteLine($"El importe a pagar por {tipoServicio} es: {importePagar:C}");
        }
        else
        {
            Console.WriteLine("Tipo de servicio no válido. Por favor, ingrese uno de los servicios mencionados.");
        }
    }

    static double CalcularImporte(string tipoServicio)
    {
        switch (tipoServicio)
        {
            case "lavado de auto":
                return 25.0;
            case "cambio de aceite":
                return 60.0;
            case "revisión mecánica":
                return 75.0;
            default:
                return -1; // Indica que el tipo de servicio no es válido
        }
    }
}

