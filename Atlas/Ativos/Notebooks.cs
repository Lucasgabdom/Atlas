using System.Reflection;

public class Notebooks
{
    public string Modelo { get; set; }
    public string Processador { get; set; }
    public string Memoria { get; set; }
    public string Armazenamento { get; set; }

    public Notebooks (string modelo, string processador, string memoria, string armazenamento)
    {
        Modelo = modelo;
        Processador = processador;
        Memoria = memoria;
        Armazenamento = armazenamento;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\n---- Exibindo Informações do Ativo de TI ----");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"Memória: {Memoria}");
        Console.WriteLine($"Armazenamento: {Armazenamento}");
    }
}