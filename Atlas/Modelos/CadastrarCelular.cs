public class CadastroCelular
{
    List<Celulares> listaCelulares = new List<Celulares>();

    public void CadastrarCelular()
    {
        Console.WriteLine("Digite o modelo do notebook:");
        string modeloCelular = Console.ReadLine()!;

        Console.WriteLine("Digite a memoria do celular:");
        string memoriaCelular = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do celular:");
        string armazenamentoCelular = Console.ReadLine()!;

        

        Celulares celular = new Celulares(modeloCelular, memoriaCelular, armazenamentoCelular);

        listaCelulares.Add(celular);

        Console.WriteLine("Celular cadastrado com sucesso");
    }
}