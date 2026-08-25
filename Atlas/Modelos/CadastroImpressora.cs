public class CadastroImpressora
{
    List<Impressoras> listaImpressoras = new List<Impressoras>();

    public void CadastroDeImpressoras()
    {
        Console.WriteLine("ID do Ativo: ");
        int idImpressora = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Patrimônio: ");
        string patrimonioImpressora= Console.ReadLine()!;

        Console.WriteLine("Fabricante: ");
        string fabricanteImpressora = Console.ReadLine()!;

        Console.WriteLine("Modelo: ");
        string modeloImpressora = Console.ReadLine()!;

        Console.WriteLine("Condição de uso: ");
        string situacaoImpressora = Console.ReadLine()!;

        Console.WriteLine("Imprime colorido: ");
        string tipoImpressora = Console.ReadLine()!;

        Console.WriteLine("Qual a voltagem da impressora:");
        string conectividadeImpressora = Console.ReadLine()!;

        Impressoras impressora = new Impressoras (idImpressora, patrimonioImpressora, fabricanteImpressora, modeloImpressora, situacaoImpressora, tipoImpressora, conectividadeImpressora);

        listaImpressoras.Add (impressora);
        Console.WriteLine("Impressora ");
    }
}