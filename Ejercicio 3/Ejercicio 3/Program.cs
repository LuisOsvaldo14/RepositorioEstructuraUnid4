using System;
class Calificaciones
{
    static void Main()
    {
        Dictionary<string, int> notas = new Dictionary<string, int>
        {
            {"Luis Osvaldo",100},
            {"Ana" ,90},
            {"Jose", 85}
        };

        notas["Jose"] = 80;
      
        Console.WriteLine($"Las notas del estudiante= " + notas["Jose"]);


    }


}