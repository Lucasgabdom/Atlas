public class IAtivos
{
    public string Nome { get; set; }
    public string Tipo { get; set; }

    public IAtivos(string nome, string tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public void CadastrarAtivo()
    {
        Console.WriteLine($"\n---- Cadastrando Ativo de TI ----");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Tipo: {Tipo}");
    }


}