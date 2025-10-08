using System;
using System.IO;

class Exemplo2
{
    static void Main()
    {
        string linha = $"{DateTime.Now}: Aula TP1 - Diário de testes.{Environment.NewLine}";
        File.AppendAllText("diario.txt", linha);
        Console.WriteLine("Linha adicionada ao diário.");
    }
}
