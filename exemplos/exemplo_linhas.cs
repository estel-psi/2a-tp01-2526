using System;
using System.IO;

class Exemplo3
{
    static void Main()
    {
        string caminho = "diario.txt";
        int linhas = File.ReadAllLines(caminho).Length;
        Console.WriteLine($"O ficheiro {caminho} tem {linhas} linhas.");
    }
}
