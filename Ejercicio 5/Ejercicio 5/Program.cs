using System;
class Muestra
{
    static void Main()
    {
        Dictionary<string, Double> Mostrar = new Dictionary<string, Double>
        {
            {"Maria",100},
            {"Angela" ,90},
            {"Redobledo", 85},
            {"Romeo", 87.44},
            {"Justin", 55.432 }
        };
        

        foreach (var Do in Mostrar) { Console.WriteLine("Mostrando llaves: "+ Do.Key); }





    }


}