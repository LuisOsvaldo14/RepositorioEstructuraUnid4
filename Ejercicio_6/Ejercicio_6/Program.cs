using System;

class NombresApellidos
{
    static void Main()
    {
        Dictionary<String, String> NoApe = new Dictionary<String, String>
        {
            {"Luis", "Peralta"},
            {"Redobledo", "Sanchez"},
            {"Jose","Ramirez"},
            {"Marie","Pie" },
            {"Rafelin","Romeo" }
        };

        foreach(var Mos in NoApe) { Console.WriteLine("Mostrando los valores: " + Mos.Value); }


    }
}

