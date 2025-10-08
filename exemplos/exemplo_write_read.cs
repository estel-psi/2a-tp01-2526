using System;
using System.IO;

class Exemplo1
{
    static void Main()
    {
        File.WriteAllText("exemplo.txt", "Olá ESTEL! Este é um teste.");
        string texto = File.ReadAllText("exemplo.txt");
        Console.WriteLine(texto);
    }
}
