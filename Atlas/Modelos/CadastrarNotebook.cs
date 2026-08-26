using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class CadastroNotebook
{
    List<Notebooks> listaDeNotebooks = new List<Notebooks>();
    private List<Colaborador> listaDeColaboradores;
    public CadastroNotebook(List<Colaborador> colaboradores)
    {
        listaDeColaboradores = colaboradores;
    }

    public void CadastrarNotebook()
    {
        Console.WriteLine("ID do Ativo: ");
        int idNotebook = int.Parse(Console.ReadLine()!);

        bool idJaExiste = listaDeNotebooks.Any( c => c.IdAtivo == idNotebook );

        if (idJaExiste) {
            Console.WriteLine("Notebook já foi cadastrado.");
            return;
        }

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

        Console.WriteLine("Qual o id do colaborador que ira receber esse produto: ");
        string idColaboradorNotebook = Console.ReadLine()!;

        Colaborador? colaborador = listaDeColaboradores.FirstOrDefault(c => c.Id == idColaboradorNotebook);
        if (colaborador == null)
        {
            Console.WriteLine("Colaborador não encontrado.");
            return;
        }

        Notebooks notebook = new Notebooks(idNotebook, patrimonioNotebook, fabricanteNotebook, modeloNotebook, situacaoNotebook, processadorNotebook, memoriaRamNotebook, armazenamentoNotebook);

        listaDeNotebooks.Add(notebook);

        if (colaborador == null)
        {
            Console.WriteLine("Colaborador não encontrado!");
            return;
        }

        colaborador.Ativos.Add(idNotebook);
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