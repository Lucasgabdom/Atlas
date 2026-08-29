public class CadastroColaboradores
{
    public DadosAtlas dadosAtlas;

    public CadastroColaboradores(DadosAtlas dados)
    {
        dadosAtlas = dados;
    }


    public void CadastroDeColaboradores()
    {
        Console.WriteLine("Digite o id do colaborador:");
        string idColaborador = Console.ReadLine()!;

        bool idJaExiste = dadosAtlas.listaDeColaboradores.Any(c => c.Id == idColaborador);

        if (idJaExiste) {
            Console.WriteLine("Colaborador já foi cadastrado!");
            return; 
        }

        Console.WriteLine("Nome do colaborador:");
        string nomeColaborador = Console.ReadLine()!;

        Console.WriteLine("E-mail do Colaborador:");
        string emailColaborador = Console.ReadLine()!;

        Console.WriteLine("Telefone do colaborador:");  
        string telefoneColaborador = Console.ReadLine()!;

        Console.WriteLine("Cardo do colaborador:");
        string cargoColaborador = Console.ReadLine()!;

        Colaborador colaboradores = new Colaborador(idColaborador, nomeColaborador, emailColaborador, telefoneColaborador, cargoColaborador);

        dadosAtlas.listaDeColaboradores.Add(colaboradores);
        Console.WriteLine("Colaborador adicionado!");

        
    }

    public void ExibirColaborador()
    {
        foreach(var colaborador in dadosAtlas.listaDeColaboradores)
        {
            Console.WriteLine("\n---- Exibindo informações ----");
            Console.WriteLine($"Id do colaborador: {colaborador.Id}");
            Console.WriteLine($"Nome do colaborador: {colaborador.Nome}");
            Console.WriteLine($"E-mail do colaborador: {colaborador.Email}");
            Console.WriteLine($"Telefone do colaborador: {colaborador.Telefone}");
            Console.WriteLine($"Cargo do colaborador: {colaborador.Cargo}");
        }
    }
}