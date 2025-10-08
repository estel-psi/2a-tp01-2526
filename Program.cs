using System;
using System.IO;

class Program
{
    static void Main()
    {
        string caminho = "mensagem.txt";
        string texto = "Olá ESTEL! Este é o meu primeiro ficheiro.";

        File.WriteAllText(caminho, texto);
        string conteudo = File.ReadAllText(caminho);

        Console.WriteLine("Ficheiro criado com sucesso!");
        Console.WriteLine("Conteúdo lido: " + conteudo);
    }
}
