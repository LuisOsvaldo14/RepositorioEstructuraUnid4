using System;

class Mostrar2
{
    static void Main()
    {
        Dictionary<String, String> Diccio = new Dictionary<String, String>
        {
            { "ID01", "Monitor Dell 24" },
            { "ID02", "Teclado Mecánico RGB" },
            { "ID03", "Mouse Inalámbrico" },
            { "ID04", "Procesador Intel i7" },
            { "ID05", "Memoria RAM 16GB" },
            { "ID06", "Disco SSD 1TB" },
            { "ID07", "Tarjeta Madre ATX" },
            { "ID08", "Fuente de Poder 750W" },
            { "ID09", "Gabinete Mid Tower" },
            { "ID10", "Cable HDMI 2.1" }
        };
        

        foreach(var Mos in Diccio)
        {
            Console.WriteLine("Keys: [" +Mos.Key+ "] Values: ["+ Mos.Value+"]");
        }
    }
}