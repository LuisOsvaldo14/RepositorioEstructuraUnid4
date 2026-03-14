using System;
class Pasies
{
    static void Main()
    {
        Dictionary<string, string> paises = new Dictionary<string, string>
        {   
            {"Argentina","Buenos aires"},
            {"Republica Dominicana","Santo Domingo"},
            {"Haiti", "Puerto Principe"}
        };
        Console.WriteLine("Paises: ");
        Console.WriteLine();
        
        foreach (var pais in paises)
        {
            Console.WriteLine(pais);
        }
    }


}


