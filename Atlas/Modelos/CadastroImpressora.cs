public class CadastroImpressora
{
    DadosAtlas dadosAtlas;

    public CadastroImpressora(DadosAtlas dados)
    {
        dadosAtlas = dados;
    }

    public void CadastroDeImpressoras()
    {
        Console.WriteLine("ID do Ativo: ");
        int idImpressora = int.Parse(Console.ReadLine()!);

        bool idJaExiste = dadosAtlas.listaImpressoras.Any(c => c.IdAtivo ==  idImpressora);

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

        Console.WriteLine("Qual o ID do colaborador que ira receber: ");
        string idColaboradroImpressora = Console.ReadLine()!;

        Colaborador? colaborador = dadosAtlas.listaDeColaboradores.FirstOrDefault(c => c.Id == idColaboradroImpressora);
        if(colaborador == null)
        {
            Console.WriteLine("Colaborador não encontrado.");
            return;
        }

        Impressoras impressora = new Impressoras (idImpressora, patrimonioImpressora, fabricanteImpressora, modeloImpressora, situacaoImpressora, tipoImpressora, conectividadeImpressora);

        dadosAtlas.listaImpressoras.Add (impressora);
        Console.WriteLine($"Impressora cadastrada com sucesso e adicionada ao colaborador {colaborador.Nome}");
    }

    public void ExibirImpressora()
    {
        foreach(var impressora in dadosAtlas.listaImpressoras)
        {
            Colaborador? colaborador = dadosAtlas.listaDeColaboradores.FirstOrDefault(c => c.Ativos.Contains(impressora.IdAtivo));
            Console.WriteLine("---- Exibindo informações da impressora ----");
            Console.WriteLine($"Id da impressora: {impressora.IdAtivo}");
            Console.WriteLine($"Modelo da impressora: {impressora.Modelo}");
            Console.WriteLine($"Tipo de impressão: {impressora.Tipo}");
            Console.WriteLine($"Voltagem da impressora {impressora.Conectividade}");
            Console.WriteLine($"A impressora está sobre dominio do colaborador de ID: {impressora.IdAtivo}");
        }
    }
}