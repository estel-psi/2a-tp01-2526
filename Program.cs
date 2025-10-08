using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=== TP1 - Tratamento de Ficheiros (Resumo) ===");
        Console.WriteLine("1 - Mensagens Secretas");
        Console.WriteLine("2 - Diário Automático");
        Console.WriteLine("3 - Contar Linhas do Diário");
        Console.WriteLine("0 - Sair");
        Console.Write("\nEscolhe uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                MensagensSecretas();
                break;
            case "2":
                DiarioAutomatico();
                break;
            case "3":
                ContarLinhas();
                break;
            default:
                Console.WriteLine("A sair...");
                break;
        }
    }

    // 🧩 Exercício 1 – Mensagens Secretas
    static void MensagensSecretas()
    {
        Console.Clear();
        Console.WriteLine("=== Mensagens Secretas ===");
        Console.Write("Escreve a tua mensagem: ");
        string mensagem = Console.ReadLine();

        string caminho = "mensagem.txt";
        File.WriteAllText(caminho, mensagem);

        string conteudo = File.ReadAllText(caminho);
        Console.WriteLine("\nMensagem gravada com sucesso!");
        Console.WriteLine($"Conteúdo do ficheiro: {conteudo}");

        Console.WriteLine("\nPressiona ENTER para continuar...");
        Console.ReadLine();
    }

    // 📚 Exercício 2 – Diário Automático
    static void DiarioAutomatico()
    {
        Console.Clear();
        Console.WriteLine("=== Diário Automático ===");
        Console.Write("Escreve a tua entrada: ");
        string entrada = Console.ReadLine();

        string linha = $"[{DateTime.Now:dd/MM/yyyy HH:mm}] {entrada}{Environment.NewLine}";
        File.AppendAllText("diario.txt", linha);

        Console.WriteLine("\nEntrada adicionada ao diário!");
        Console.WriteLine("Pressiona ENTER para continuar...");
        Console.ReadLine();
    }

    // 🔍 Exercício 3 – Contar Linhas
    static void ContarLinhas()
    {
        Console.Clear();
        Console.WriteLine("=== Contar Linhas do Diário ===");

        string caminho = "diario.txt";

        if (!File.Exists(caminho))
        {
            Console.WriteLine("O ficheiro do diário ainda não existe!");
        }
        else
        {
            string[] linhas = File.ReadAllLines(caminho);
            int total = linhas.Length;

            Console.WriteLine($"\nO diário contém {total} entradas.\n");

            if (total > 0)
            {
                Console.WriteLine($"Primeira: {linhas[0]}");
                Console.WriteLine($"Última:   {linhas[total - 1]}");
            }
        }

        Console.WriteLine("\nPressiona ENTER para continuar...");
        Console.ReadLine();
    }
}
