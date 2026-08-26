public class CadastroImpressora
{
    List<Impressoras> listaImpressoras = new List<Impressoras>();

    public void CadastroDeImpressoras()
    {
        Console.WriteLine("ID do Ativo: ");
        int idImpressora = int.Parse(Console.ReadLine()!);

        bool idJaExiste = listaImpressoras.Any(c => c.IdAtivo ==  idImpressora);

        if (idJaExiste)
        {
            Console.WriteLine("Impressora já foi cadastrada!");
            return;
        }

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

    public void ExibirImpressora()
    {
        foreach(var impressora in listaImpressoras)
        {
            Console.WriteLine("---- Exibindo informações da impressora ----");
            Console.WriteLine($"Id da impressora: {impressora.IdAtivo}");
            Console.WriteLine($"Modelo da impressora: {impressora.Modelo}");
            Console.WriteLine($"Tipo de impressão: {impressora.Tipo}");
            Console.WriteLine($"Voltagem da impressora {impressora.Conectividade}");
        }
    }
}