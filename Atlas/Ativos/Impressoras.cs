public class Impressoras
{
    public string Modelo { get; set; }
    public string Tipo { get; set; }
    public string Conectividade { get; set; }
    public Impressoras(string modelo, string tipo, string conectividade)
    {
        Modelo = modelo;
        Tipo = tipo;
        Conectividade = conectividade;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"\n---- Exibindo Informações da Impressora ----");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Conectividade: {Conectividade}");
    }
}