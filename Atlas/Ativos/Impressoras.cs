public class Impressoras : Ativo
{
    public string Tipo { get; set; }
    public string Conectividade { get; set; }
    public Impressoras(int idAtivo, string patrimonio, string fabricante, string modelo, string situacao, string tipo, string conectividade) : base(idAtivo, patrimonio, fabricante, modelo, situacao)
    {
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