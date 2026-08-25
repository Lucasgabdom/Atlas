using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class CadastroNotebook
{
    List<Notebooks> listaDeNotebooks = new List<Notebooks>();

    public void CadastrarNotebook()
    {
        Console.WriteLine("ID do Ativo: ");
        int idNotebook = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Patrimônio: ");
        string patrimonioNotebook = Console.ReadLine()!;

        Console.WriteLine("Fabricante: ");
        string fabricanteNotebook = Console.ReadLine()!;

        Console.WriteLine("Modelo: ");
        string modeloNotebook = Console.ReadLine()!;

        Console.WriteLine("Condição de uso: ");
        string situacaoNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o processador do notebook:");
        string processadorNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do notebook:");
        string memoriaRamNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do notebook:");
        string armazenamentoNotebook = Console.ReadLine()!;

        Notebooks notebook = new Notebooks(idNotebook, patrimonioNotebook, fabricanteNotebook, modeloNotebook, situacaoNotebook, processadorNotebook, memoriaRamNotebook, armazenamentoNotebook);

        listaDeNotebooks.Add(notebook);
        Console.WriteLine("Notebook cadastro com sucesso!");

    }

    public void ExibindoNotebooks()
    {
        foreach (var notebook in listaDeNotebooks)
        {
            Console.WriteLine($"---- Exibindo informações do notebook ----");
            Console.WriteLine($"Id do notebook: {notebook.IdAtivo}");
            Console.WriteLine($"Processador do notebook: {notebook.Processador}");
            Console.WriteLine($"Memória do notebook: {notebook.Memoria}");
            Console.WriteLine($"Armazenamento do notebook: {notebook.Armazenamento}");
        }

    }

    public void GerarJson()
    {
        string criandoArquivo = JsonSerializer.Serialize(listaDeNotebooks);
        string nomeDoAquivo = "notebooks.json";

        File.WriteAllText(nomeDoAquivo, criandoArquivo);
    }

}