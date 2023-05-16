using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        var name = Console.ReadLine();

        var InvertedName = "";
        for (var i = name.Length - 1; i >= 0; i--)
        {
            InvertedName += name[i];
        }

        Console.WriteLine("¡Hasta luego " + InvertedName + "!");
    }
}