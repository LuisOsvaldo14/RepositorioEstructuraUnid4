using System;
class Eliminacion
{
    static void Main()
    {
        Dictionary<string, int> Eli = new Dictionary<string, int>
        {
            {"Maria",100},
            {"Angela" ,90},
            {"Redobledo", 85}
        };
        Eli.Remove("Angela");

        foreach(var Elimi in Eli) { Console.WriteLine(Elimi); }

        



    }


}
