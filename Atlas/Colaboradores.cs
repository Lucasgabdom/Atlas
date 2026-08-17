public class Colaborador
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Cargo { get; set; }

    public Colaborador(string id, string nome, string email, string telefone, string cargo)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Cargo = cargo;
    }


    public void ExibirInformacoes()
    {
        Console.WriteLine($"\n---- Exibindo Informações do Colaborador ----");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Cargo: {Cargo}");
    }
}