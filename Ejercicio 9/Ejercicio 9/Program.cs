using System;

class sumarValues
{
    static void Main()
    {
        Dictionary<String, Double> Suma = new Dictionary<String, Double>
        {
            { "Laptop", 850.50 },
            { "Mouse", 25.99 },
            { "Teclado", 45.00 },
            { "Monitor", 199.99 },
            { "Disco Duro", 120.75 },
            { "Memoria RAM", 89.90 },
            { "Procesador", 320.00 },
            { "Tarjeta de Video", 450.25 },
            { "Fuente Poder", 75.50 },
            { "Gabinete", 60.00 }
        };
        Console.Write("La suma de todos los valores es = ");
        Console.WriteLine(Suma.Values.Sum());

    }
}
