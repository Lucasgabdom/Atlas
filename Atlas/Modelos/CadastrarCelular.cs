public class CadastroCelular
{
    List<Celulares> listaCelulares = new List<Celulares>();

    public void CadastrarCelular()
    {

        Console.WriteLine("ID do Ativo: ");
        int idCelular = int.Parse(Console.ReadLine()!);

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


        Celulares celular = new Celulares(idCelular, patrimonioCelular, fabricanteCelular, modeloCelular, situacaoCelular, memoriaCelular, armazenamentoCelular);

        listaCelulares.Add(celular);

        Console.WriteLine("Celular cadastrado com sucesso");
    }
}