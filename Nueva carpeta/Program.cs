using System;

public class CochinitaFeliz
{
    private int totalTacos;
    private int totalTortas;

    public void RegistraVenta(int tacos, int tortas)
    {
        totalTacos += tacos;
        totalTortas += tortas;
    }

    public int CuantosTacos()
    {
        return totalTacos;
    }

    public int CuantasTortas()
    {
        return totalTortas;
    }

    public string VendiElTripleDeTacos()
    {
        return (totalTacos > totalTortas * 3) ? "SI" : "NO";
    }
}

public class Program
{
    public static void Main()
    {
        CochinitaFeliz puesto = new CochinitaFeliz();
        bool hayMasVentas = true;

        Console.WriteLine("Bienvenido al sistema de registro de ventas de Cochinita Feliz\n");

        while (hayMasVentas)
        {
            Console.Write("Ingrese la cantidad de tacos vendidos: ");
            int tacos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de tortas vendidas: ");
            int tortas = Convert.ToInt32(Console.ReadLine());

            puesto.RegistraVenta(tacos, tortas);

            Console.Write("\n¿Hay más ventas por registrar? (s/n): ");
            var input = Console.ReadLine();
            hayMasVentas = input != null && input.ToLower().StartsWith("s");
            Console.WriteLine();
        }

        Console.WriteLine("\nResumen de Ventas:");
        Console.WriteLine($"Total de tacos vendidos: {puesto.CuantosTacos()}");
        Console.WriteLine($"Total de tortas vendidas: {puesto.CuantasTortas()}");
        Console.WriteLine($"¿Los tacos superaron el triple de las tortas?: {puesto.VendiElTripleDeTacos()}");
    }
}