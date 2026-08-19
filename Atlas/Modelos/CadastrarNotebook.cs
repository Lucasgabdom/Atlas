public class CadastroNotebook
{
    List<Notebooks> listaDeNotebooks = new List<Notebooks>();

    public void CadastrarNotebook()
    {
        Console.WriteLine("Digite o modelo do notebook:");
        string modeloNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o processador do notebook:");
        string processadorNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do notebook:");
        string memoriaRamNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do notebook:");
        string armazenamentoNotebook = Console.ReadLine()!;

        Notebooks notebook = new Notebooks(modeloNotebook, processadorNotebook, memoriaRamNotebook, armazenamentoNotebook);

        listaDeNotebooks.Add(notebook);
        Console.WriteLine("Notebook cadastro com sucesso!");

    }
}