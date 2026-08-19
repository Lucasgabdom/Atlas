public class CadastroColaboradores
{
    List<Colaborador> listaDeColoboradores = new List<Colaborador>();

    public void CadastroDeColaboradores()
    {
        Console.WriteLine("Digite o id do colaborador:");
        string idColaborador = Console.ReadLine()!;

        Console.WriteLine("Nome do colaborador:");
        string nomeColaborador = Console.ReadLine()!;

        Console.WriteLine("E-mail do Colaborador:");
        string emailColaborador = Console.ReadLine()!;

        Console.WriteLine("Telefone do colaborador:");
        string telefoneColaborador = Console.ReadLine()!;

        Console.WriteLine("Cardo do colaborador:");
        string cargoColaborador = Console.ReadLine()!;

        Colaborador colaboradores = new Colaborador(idColaborador, nomeColaborador, emailColaborador, telefoneColaborador, cargoColaborador);

        listaDeColoboradores.Add(colaboradores);
        Console.WriteLine("Colaborador adicionado!");
    }
}