using System;
class Productos
{
    static void Main()
    {
        Dictionary<string, int> Productos = new Dictionary<string, int>
        {
            {"Jabon",120},
            {"Pollo Frito" ,400},
            {"Coca Cola", 50}
        };
        Console.WriteLine("El precio de la Coca Cola es:" + Productos["Coca Cola"]);
        Console.WriteLine();


    }


}
