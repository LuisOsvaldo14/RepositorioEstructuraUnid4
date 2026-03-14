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
        };

        if (NoApe.ContainsKey("Luis"))
        {
            Console.WriteLine("La llave esta ahi");
        }
        if (NoApe.ContainsKey("Maria"))
        {
            Console.WriteLine("La llave esta ahi");
        }
        else { Console.WriteLine("La llave no esta ahi"); }



    }
}
