public class CadastroCelular
{
    public DadosAtlas dadosAtlas;

    public CadastroCelular(DadosAtlas dados)
    {
        dadosAtlas = dados;        
    }

    public void CadastrarCelular()
    {

        Console.WriteLine("ID do Ativo: ");
        int idCelular = int.Parse(Console.ReadLine()!);

        bool idJaExiste = dadosAtlas.listaCelulares.Any(c => c.IdAtivo == idCelular);

        if (idJaExiste) {
            Console.WriteLine("Celular já foi cadastrado!");
            return;   
        }

        Console.WriteLine("Patrimônio: ");
        string patrimonioCelular = Console.ReadLine()!;

        Console.WriteLine("Fabricante: ");
        string fabricanteCelular = Console.ReadLine()!;

        Console.WriteLine("Modelo: ");
        string modeloCelular  = Console.ReadLine()!;

        Console.WriteLine("Condição de uso: ");
        string situacaoCelular = Console.ReadLine()!;

        Console.WriteLine("Memoria Ram:");
        string memoriaCelular = Console.ReadLine()!;

        Console.WriteLine("Armazenamento:");
        string armazenamentoCelular = Console.ReadLine()!;

        Console.WriteLine("Qual o id do colaborador que era receber: ");
        string idColaboradorCelular = Console.ReadLine()!;

        Colaborador? colaborador = dadosAtlas.listaDeColaboradores.FirstOrDefault(c => c.Id == idColaboradorCelular);
        if (colaborador == null)
        {
            Console.WriteLine("Colaborador não encontrado.");
            return;
        }


        Celulares celular = new Celulares(idCelular, patrimonioCelular, fabricanteCelular, modeloCelular, situacaoCelular, memoriaCelular, armazenamentoCelular);

        dadosAtlas.listaCelulares.Add(celular);

        Console.WriteLine($"Celular cadastrado com sucesso e adicionado ao colaborador {colaborador.Nome}");
    }

    public void ExibirCelulares()
    { 
        foreach (var celulares in dadosAtlas.listaCelulares)
        {
            Colaborador? colaborador = dadosAtlas.listaDeColaboradores.FirstOrDefault(c => c.Ativos.Contains(celulares.IdAtivo));

            Console.WriteLine($"---- Exibindo informações dos celulares ----");
            Console.WriteLine($"Id do celular: {celulares.IdAtivo}");
            Console.WriteLine($"Modelo: {celulares.Modelo}");
            Console.WriteLine($"Memoria RAM: {celulares.MemoriaRam}");
            Console.WriteLine($"Armazenamento: {celulares.Armazenamento}");
            Console.WriteLine($"Situação: {celulares.Situacao}");
            Console.WriteLine($"O celular está sobre dominio do colaborador de ID: {celulares.IdAtivo}");
        }
    }
}